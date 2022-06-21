//ENTITY LAYER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayers
{
    public class UserEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string DateOfBirth { get; set; }

        public string Email { get; set; }

        public string password { get; set; }

        public int MusicId { get; set; }

        public string Description { get; set; }

        public UserEntity()
        {

        }
    }

}
