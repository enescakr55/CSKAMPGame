using CSharp_Oyun.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Oyun.Class
{
    class CampaignManager : Manager
    {
        public int Cid = 0;
        public List<Campaign> Campaigns = new List<Campaign> { };
        public void Add(Entity entity)
        {
            Campaign p = (Campaign)entity;
            Cid += 1;
            p.Id = Cid;
            Campaigns.Add(p);
        }



        public void DeletewithId(int id)
        {
            Campaigns.RemoveAll(r => r.Id == id);
        }

        public void Show()
        {
            foreach (var campaign in Campaigns)
            {
                Console.WriteLine("Kampanya Id:"+campaign.Id+"Kampanya Adı:" + campaign.KampanyaAdi + "Kampanya İndirim Oranı: "+campaign.IndirimOrani+"\n");
            }
        }

    }
}
