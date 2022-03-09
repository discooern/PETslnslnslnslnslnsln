using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PETslnslnslnslnslnsln
{
    public class Data
    {
        PETDBEntities db = new PETDBEntities();

        #region Properties
        // Collections for data
        public ObservableCollection<Agents> AgentsList
        {
            get
            {
                ObservableCollection<Agents> agentsList = new ObservableCollection<Agents>(db.Agents.SqlQuery("Select * from Agents").ToList<Agents>());
                return agentsList;
            }
        }

        public ObservableCollection<Currencies> CurrenciesList
        {
            get
            {
                ObservableCollection<Currencies> currenciesList = new ObservableCollection<Currencies>(db.Currencies.SqlQuery("Select * from Currencies").ToList<Currencies>());
                return currenciesList;
            }
        }

        public ObservableCollection<Informants> InformantsList
        {
            get
            {
                ObservableCollection<Informants> informantsList = new ObservableCollection<Informants>(db.Informants.SqlQuery("Select * from Informants").ToList<Informants>());
                return informantsList;
            }
        }

        public ObservableCollection<Logs> LogsList
        {
            get
            {
                ObservableCollection<Logs> logsList = new ObservableCollection<Logs>(db.Logs.SqlQuery("Select * from Logs").ToList<Logs>());
                return logsList;
            }
        }

        public ObservableCollection<Nationalities> NationalitiesList
        {
            get
            {
                ObservableCollection<Nationalities> nationalitiesList = new ObservableCollection<Nationalities>(db.Nationalities.SqlQuery("Select * from Nationalities").ToList<Nationalities>());
                return nationalitiesList;
            }
        }

        public ObservableCollection<ObservantGroups> ObservantGroupsList
        {
            get
            {
                ObservableCollection<ObservantGroups> observantGroupsList = new ObservableCollection<ObservantGroups>(db.ObservantGroups.SqlQuery("Select * from ObservantGroups").ToList<ObservantGroups>());
                return observantGroupsList;
            }
        }

        public ObservableCollection<Observants> ObservantsList
        {
            get
            {
                ObservableCollection<Observants> observantsList = new ObservableCollection<Observants>(db.Observants.SqlQuery("Select * from Observants").ToList<Observants>());
                return observantsList;
            }
        }

        public ObservableCollection<Observations> ObservationsList
        {
            get
            {
                ObservableCollection<Observations> observationsList = new ObservableCollection<Observations>(db.Observations.SqlQuery("Select * from Observations").ToList<Observations>());
                return observationsList;
            }
        }

        public ObservableCollection<Payments> PaymentsList
        {
            get
            {
                ObservableCollection<Payments> paymentsList = new ObservableCollection<Payments>(db.Payments.SqlQuery("Select * from Payments").ToList<Payments>());
                return paymentsList;
            }
        }

        public ObservableCollection<Persons> PersonsList
        {
            get
            {
                ObservableCollection<Persons> personsList = new ObservableCollection<Persons>(db.Persons.SqlQuery("Select * from Persons").ToList<Persons>());
                return personsList;
            }
        }
        #endregion

        #region Methods
        // Data add/update/delete methods 
        #region Agents
        /// <summary>
        /// Agents add/update/remove methods using tmp as input
        /// </summary>
        /// <param name="tmp"></param>
        public void AddAgent(Agents tmp)
        {
            db.Agents.Add(tmp);
            db.SaveChanges();
        }
        public void UpdateAgent(Agents tmp)
        {

        }
        public void RemoveAgent(Agents tmp)
        {

        }
        #endregion

        #region Informants
        /// <summary>
        /// Informants add/update/remove methods using tmp as input
        /// </summary>
        /// <param name="tmp"></param>
        public void AddInformant(Informants tmp)
        {

        }
        public void UpdateInformant(Informants tmp)
        {

        }
        public void RemoveInformant(Informants tmp)
        {

        }
        #endregion

        #region Observants
        /// <summary>
        /// Observants add/update/remove methods using tmp as input
        /// </summary>
        /// <param name="tmp"></param>
        public void AddObservant(Observants tmp)
        {

        }
        public void UpdateObservant(Observants tmp)
        {

        }
        public void RemoveObservant(Observants tmp)
        {

        }
        #endregion

        #region Persons
        /// <summary>
        /// Persons add/update/remove methods using tmp as input
        /// </summary>
        /// <param name="tmp"></param>
        public void AddPerson(Persons tmp)
        {
            db.Persons.Add(tmp);
            db.SaveChanges();
        }
        public void UpdatePerson(Persons tmp)
        {

        }
        public void RemovePerson(Persons tmp)
        {

        }
        #endregion

        #region Logs
        /// <summary>
        /// Logs add method using tmp as input
        /// </summary>
        /// <param name="tmp"></param>
        public void AddLog(Logs tmp)
        {

        }
        #endregion

        #region ObservantGroups
        /// <summary>
        /// ObservantGroups add/update/remove methods using tmp as input
        /// </summary>
        /// <param name="tmp"></param>
        public void AddObservantGroup(ObservantGroups tmp)
        {

        }
        public void UpdateObservantGroup(ObservantGroups tmp)
        {

        }
        public void RemoveObservantGroup(ObservantGroups tmp)
        {

        }
        #endregion

        #region Payments
        /// <summary>
        /// Payments add/update/remove methods using tmp as input
        /// </summary>
        /// <param name="tmp"></param>
        public void AddPayment(Payments tmp)
        {

        }
        public void UpdatePayment(Payments tmp)
        {

        }
        public void RemovePayment(Payments tmp)
        {

        }
        #endregion

        #endregion
    }
}
