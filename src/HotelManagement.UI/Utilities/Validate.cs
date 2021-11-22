using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using HotelManagement.UI.Contracts;

namespace HotelManagement.UI.Utilities
{
    public class Validate : IValidate
    {
        private readonly IList<bool> _result;
        private readonly IList<ValidateModel> _validate;

        public Validate()
        {
            _result = new List<bool>();
            _validate = new List<ValidateModel>();
        }

        public IValidate Add(ValidateModel model)
        {
            _validate.Add(model);
            return this;
        }

        public IValidate Run()
        {
            _result.Clear();
            foreach (var model in _validate)
            {
                if (model.Control.Text.Trim() == string.Empty)
                {
                    model.Control.ErrorMessage = "Không được để trống ô này";
                    model.Control.BorderColor = Color.Red;
                    model.Control.IsError = true;
                    _result.Add(false);
                    continue;
                }

                if (!model.Pattern.IsMatch(model.Control.Text.Trim()))
                {
                    model.Control.ErrorMessage = model.Error;
                    model.Control.BorderColor = Color.Red;
                    model.Control.IsError = true;
                    _result.Add(false);
                    continue;
                }
                model.Control.BorderColor = Color.White;
                model.Control.IsError = false;
                _result.Add(true);
            }

            return this;
        }

        public bool Accept() => _result.All(x => x);
    }
}