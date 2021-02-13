using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AddedBrand = "Marka ismi eklendi";
        public static string DeletedBrand = "Marka ismi silindi";
        public static string UpdatedBrand = "Marka ismi güncellendi";
        public static string FailedBrandAddOrUpdate = "Marka ismi en az 2 karakter olmalıdır!";

        public static string AddedCar = "Araba eklendi";
        public static string DeletedCar = "Araba silindi";
        public static string UpdatedCar = "Araba güncellendi";
        public static string FailedCarAddOrUpdate = "Günlük fiyat 0 TL'den büyük olmalıdır!";

        public static string AddedColor = "Araç rengi eklendi";
        public static string DeletedColor = "Araç rengi silindi";
        public static string UpdatedColor = "Araç rengi güncellendi";

        public static string AddedCustomer = "Müşteri bilgileri eklendi";
        public static string DeletedCustomer = "Müşteri bilgileri silindi";
        public static string UpdatedCustomer = "Müşteri bilgileri güncellendi";


        public static string AddedUser = "Kullanıcı bilgileri eklendi";
        public static string DeletedUser = "Kullanıcı bilgileri silindi";
        public static string UpdatedUser = "Kullanıcı bilgileri güncellendi";


        public static string AddedRental = "Kiralama işlemi gerçekleştirildi";
        public static string DeletedRental = "Kiralama işlemi iptal edildi";
        public static string UpdatedRental = "Kiralama işlemi güncellendi";
        public static string FailedRentalAddOrUpdate = "Araba henüz teslim edilmediği için kiralanamaz!";
        public static string ReturnedRental = "Kiralanan araba teslim edildi";

    }
}