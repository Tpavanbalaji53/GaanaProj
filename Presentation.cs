//present LAYER
using BussinessLogicLayers;
using EntityLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    class Presentation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gaana App");
            Console.WriteLine("Press 1 : Register");
            Console.WriteLine("Press 2 : Login");

            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
                Register();
            else if (choice == 2)
                Login();
            else
                Console.WriteLine("Enter either 1 or 2");

        }
        public static UserEntity Register()
        {
            UserEntity user = new UserEntity();
            Console.WriteLine("Enter User ID");
            user.UserId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName ");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            user.Gender = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth");
            user.DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter Email");
            user.Email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            user.password = Console.ReadLine();

            Console.WriteLine("Press 1: Submit");
            Console.WriteLine("Press 2: Cancel and Go Back");

            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
                return user;
            else if (choice == 2)
                user = null;
            else
                Console.WriteLine("Enter either 1 or 2");

            return null;

        }
        static void Login()
        {
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();

            Console.WriteLine("Press 1: Submit");
            Console.WriteLine("Press 2: Cancel and Go Back");

            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
                DisplayGaanaApp(email, password);

        }

        static void DisplayGaanaApp(string email, string password)
        {
            Console.WriteLine("Welcome to Gaana App");
            Console.WriteLine("Press 1: Create new Music");
            Console.WriteLine("Press 2: View All Music");
            Console.WriteLine("Press 3: Edit My Music");
            Console.WriteLine("Press 4: Delete My Music");

            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
                CreateMusic(email, password);
            else if (choice == 2)
                ViewMusic(email, password);
            else if (choice == 3)
                DeleteyourMusic(email, password);
            else if (choice == 4)
                EditMusicDescription(email, password);


        }

       static void CreateMusic(string email, string password)
        {
            Console.WriteLine("Enter Music Id");
            string captionMassage = Console.ReadLine();
            Console.WriteLine("Enter Music Title");
            int ArticleId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Music Description ");

            Console.WriteLine("Press 1: Submit");
            Console.WriteLine("Press 2: Cancel and Go Back");

            UserEntity userGaana = new UserEntity();
            userGaana.ArticleMessage = ViewMusic;
            userGaana.MusicId = MusicId;
            userGaana.Description = DescriptionMessage;
            userGaana.Email = email;
            userGaana.password = password;

            BussinessLogicLayer BussinessLogicLayerReference = new BussinessLogicLayer();
            UserEntity entity = BussinessLogicLayerReference.CreateMusic(userGaana);


        }
        static void ViewMusic(string email, string password)
        {


            UserEntity viewUser = new UserEntity();
            viewUser.Email = email;
            viewUser.password = password;

            BussinessLogicLayer bussinessLogicLayerReference = new BussinessLogicLayer();
            UserEntity entity = bussinessLogicLayerReference.ViewAllMusic(viewUser);

            // foreach (UserEntity reference in entity)
            {
                Console.WriteLine("Music ID" + entity.MusicId);
                // Console.WriteLine(“ Title ” +entity.Title);
                // Console.WriteLine("Description" + entity.description);
                Console.WriteLine("First Name" + entity.FirstName);

            }
        }

        static void DeleteyourMusic(string email, string password)
        {
            Console.WriteLine("Music ID");
            int MusicId = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Press 1: Submit");
            Console.WriteLine("Press 2: Cancel and Go Back");

            int choice = Convert.ToInt16(Console.ReadLine());

            UserEntity user = new UserEntity();
            user.Email = email;
            user.password = password;
            user.MusicId = MusicId;

           // if (choice == 1)
               BussinessLogicLayer bussinessLogicLayerReference = new BussinessLogicLayer();
           // UserEntity entity = bussinessLogicLayerReference.DeleteMusic(user);

        }

        static void EditMusicDescription(string email, string password)
        {
            Console.WriteLine("Enter MusicId");
            string newMusicId = Console.ReadLine();
            Console.WriteLine("Enter MusicDescription");
            string newMusicDescription = Console.ReadLine();
            Console.WriteLine("Press 1: Submit new Password");
            Console.WriteLine("Press 2: Cancel and Go Back");

            UserEntity user = new UserEntity();
            user.Email = email;
            user.password = password;
             //user.password = new Password;

            //if (choice == 1)
            BussinessLogicLayer bussinessLogicLayerReference = new BussinessLogicLayer();
            bussinessLogicLayerReference.CreateMusic(user);
        }
    }
}
