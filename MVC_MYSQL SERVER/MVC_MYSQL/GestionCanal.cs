using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using MVC_MYSQL.Controleur;

namespace MVC_MYSQL
{
    public  class GestionCanal
    {
        public GestionCanal()
        {
        }
        TcpChannel channel;

        [Obsolete]
        public void Demarrer()
        {
            channel = null;
            channel = new TcpChannel(1070);

            try
            {
                ChannelServices.RegisterChannel(channel);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        public void Canal()
        {
            try
            {

                Demarrer();
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Ctrl_Employe),
                "InterfaceEmploye", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(CtrlUtilisateur),
               "InterfaceUtilisateur", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Ctrl_Supply),
               "InterfaceSupply", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Ctrl_Sales),
              "InterfaceSales", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ctrlTransaction),
              "InterfaceTransaction", WellKnownObjectMode.Singleton);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Ctrl_Admin),
              "InterfaceAdmin", WellKnownObjectMode.Singleton);



            }
            catch
            {
                MessageBox.Show("Le serveur  n'a pas démarré  ");

            }

        }

        public void Arreter()
        {

            try
            {
                ChannelServices.UnregisterChannel(channel);

            }
            catch (Exception ex)
            {
                MessageBox.Show("CLIQUER SUR OK");
            }

        }
      

    }
}
