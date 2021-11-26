using System.Text.RegularExpressions;

namespace HotelManagement.UI.Utilities
{
    public static class Pattern
    {
        public static readonly Regex Name = new (@"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂẾưăạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳýỵỷỹ\s]+$");
        public static readonly Regex PhoneNumber = new(@"(84|0[3|5|7|8|9])+([0-9]{8})\b");
        public static readonly Regex IdentityNumber = new(@"\d{12}|");
        public static readonly Regex Number = new(@"^\d*$");
    }
}