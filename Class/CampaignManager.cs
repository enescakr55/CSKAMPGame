using CSharp_Oyun.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Oyun.Class
{
    class CampaignManager : Manager
    {
        public int Cid = 0;
        public static List<Campaign> Campaigns = new List<Campaign> { };
        public void Add(Entity entity)
        {
            Campaign p = (Campaign)entity;
            Cid += 1;
            p.Id = Cid;
            Campaigns.Add(p);
            Console.WriteLine("Kampanya Eklendi");
        }



        public void DeletewithId(int id)
        {
            Campaigns.RemoveAll(r => r.Id == id);
        }

        public Campaign ReturnById(int id)
        {
            foreach (var campaign in Campaigns)
            {
                if (campaign.Id == id)
                {
                    
                    return campaign;
                }
            }
            return null;
        }

        public void Show()
        {
            if (Campaigns.Count == 0)
            {
                Console.WriteLine("Hiç kampanya eklenmemiş");
            }
            foreach (var campaign in Campaigns)
            {
                Console.WriteLine("Kampanya Id:"+campaign.Id+"Kampanya Adı:" + campaign.KampanyaAdi + "Kampanya İndirim Oranı: "+campaign.IndirimOrani+"\n");
            }
        }

    }
}
