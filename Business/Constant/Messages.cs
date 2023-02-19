using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constant
{
    public static class Messages
    {
        public static string AddedMessage = "Araç sisteme başarıyla eklenmiştir";
        public static string AddedInvalidMessage = "Girdiğiniz araç sistemimize eklemek için uygun değil.";
        public static string GetAllMessage = "Araçlar başarıyla listelendi";

        public static string GetAllInvalidMessage =
            "Sistemimiz kapalı olduğunda dolayı işlem gerçekleştirilemiyor";

        public static string UpdatedInvalidMessage =
            "Girdiğiniz araç bilgileri ile sistemimizde bir güncelleme yapılamaz";

        public static string UpdatedMessage = "Araç bilgileri güncellendi";
        public static string DeletedMessage = "Belirtmiş olduğunuz araç sistemimizden başarıyla silinmiştir";
        public static string ColorAdded = "Renk sisteme başarıyla eklenmiştir";
        public static string BrandAdded = "Marka sisteme başarıyla eklenmiştir";
        public static string ColorDeleted = "Renk sistemden silinmiştir";
        public static string BrandDeleted = "Marka sistemden silinmiştir;";
        public static string ColorUpdated = "Renk sistemde başarıyla güncellenmiştir";
        public static string BrandUpdated = "Marka sistemde başarıyla güncellenmiştir";
        public static string ColorListed = "Renkler başarıyla listelenmiştir";
        public static string BrandListed = "Markalar başarıyla listelenmmiştir";
        public static string UserAdded = "Kullanıcı sisteme başarıyla eklenmiştir";
        public static string CustomerAdded = "Müşteri sisteme başarıyla eklenmiştir";
        public static string UserDeleted = "Kullanıcı sistemden başarıyla silinmiştir";
        public static string CustomerDeleted = "Müşteri sistemden başarıyla silinmiştir";
        public static string UserUpdated = "Kullanıcı bilgileri başarıyla güncellenmiştir";
        public static string CustomerUpdated = "Müşteri bilgileri başarıyla güncellenmiştir";
        public static string UserGetAll = "Kullanıcılar başarıyıla listelendi";
        public static string CustomerGetAll = "Müşteriler başarıyla listelendi";
        public static string RentalGetAll = "Kiralanan arabalar başarıyla listelendi";

        public static string RentalAdded =
            "Araba kiralama işlemi başarıyla gerçekleşmiştir belirtiğiniz gün sabah 9 itibari ile aracınızı şirketimizden teslim alabilirsiniz";

        public static string RentalInvalidAdded = "Bu araç şu anda kiralanamamaktadır.";
        public static string RentalDeleted = "Kiralama listesinden çıkarılmıştır";
        public static string RentalUpdated = "Bilgiler güncellenmiştir";

        public static string RentalInvalidUpdated =
            "Seçilen araç şu anda kirada olduğundan dolayı bu güncelleme işlemi gerçekleştirilemez";
    }
}
