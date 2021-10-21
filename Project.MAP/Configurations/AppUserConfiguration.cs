using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Configurations
{
    public class AppUserConfiguration: BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.ID); //Birebir ilişki için ayarımızı burada yaptık

            //Bizim AppUser classımızın bizim yaptığımız property'lerin yanı sıra Microsoft'un Identity kütüphanesinden gelen property'leri de olacaktır. Identity'den gelen bu property'lerin içerisinde primary key olan ve Id ismine sahip bir property daha olacaktır. Dolayısıyla bu class tabloya çevrilirken hem bizim ID property'miz hem de Identity'den gönderdiği Id property'si Sql'daki Incasesensitive durum yüzünden aynı sütun sayılarak size migration durumunda bir tabloda aynı isimde iki sütun olamaz diye hata çıkaracaktır. Dolayısıyla bizim burada ID'miz C#'ta kalsa da onu (kendi ID'mizi) Sql'e göndermememiz gerekecektir.

            builder.Ignore(x => x.ID);
        }
    }
}
