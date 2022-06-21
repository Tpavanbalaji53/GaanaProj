//BUSSINESS LOGIC LAYER
using EntityLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
namespace BussinessLogicLayers
{
    public class BussinessLogicLayer
    {
        public static void CreateMusic(UserEntity user)
        {
            DataAccessLayer reference = new DataAccessLayer();
            object p = reference.CreateMusic(user);


        }
        public static List<UserEntity> ViewMusic(UserEntity user)
        {
            DataAccessLayer reference = new DataAccessLayer();
            UserEntity userEntity = reference.ViewMusic(user);
            UserEntity user = userEntity;


            return user;
        }

        public static void DeleteyourMusic(UserEntity user)
        {
            DataAccessLayer referece = new DataAccessLayer();
            UserEntity user;
            _ = referece.ViewAllMusic(user);
        }
    }
}
