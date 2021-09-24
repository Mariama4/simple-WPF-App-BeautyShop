using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShopApp.AppDataFile
{
    class CurrentUser
    {
        public static int Id { get; set; }

        public static string Name { get; set; }

        public static string Surname { get; set; }

        public static string Post { get; set; }

        public static void loginUser(int idUser, string name, string surName, string post)
        {
            Id = idUser;
            Name = name;
            Surname = surName;
            Post = post;

            ConnectOdb.Select("INSERT INTO `dbo`.`logs` (`userId`, `action`, `time`) VALUES('" + Id.ToString() + "', 'Вход', now());");

        }

        public static void ExitUser(int Id)
        {
            ConnectOdb.Select("INSERT INTO `dbo`.`logs` (`userId`, `action`, `time`) VALUES ('" + Id + "', 'Выход', Now());");
        }

    }
}
