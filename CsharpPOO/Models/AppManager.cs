using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPOO.Models
{
    internal class AppManager
    {
        public string AppTitle { get; set; }
        public List<SocialNetwork> SocialNetworks { get; set; }
        public List<SocialNetworkWithGroups> SocialNetworkWithGroups { get; set; }

        public AppManager()
        {
            AppTitle = "Administrador de Redes Sociales";
            SocialNetworks = new List<SocialNetwork>();
            SocialNetworkWithGroups = new List<SocialNetworkWithGroups>();
            InitializeSocialNetworrks();
        }
        public void InitializeSocialNetworrks()
        {
            SocialNetworks.Add(new SocialNetworkWithGroups()
            {
                Name = "Twitter",
                Description = "Esta es la red de twitter",
                Users = new List<User>(),
                DateCreated = new DateTime(2008,1,20)
            });
            SocialNetworks.Add(new SocialNetworkWithGroups()
            {
                Name = "Instagram",
                Description = "Para videos cortos y fotos",
                Users = new List<User>(),
                DateCreated = new DateTime(2010, 1, 20)
            });
            SocialNetworkWithGroups.Add(new SocialNetworkWithGroups()
            {
                Name = "Facebook",
                Description = "Para videos, fotos y grupos",
                Users = new List<User>(),
                Groups = new List<string>(),
                DateCreated = new DateTime(2010,1,1)
            });
        }
    }
}
