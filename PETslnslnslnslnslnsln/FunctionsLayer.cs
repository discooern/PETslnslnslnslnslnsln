using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PETslnslnslnslnslnsln
{
    public class FunctionsLayer : INotifyPropertyChanged
    {
        Data data = new Data();

        #region Properties
        // Collections of data
        public ObservableCollection<Agents> AgentsList
        {
            get { return data.AgentsList; }
        }
        public ObservableCollection<Currencies> CurrenciesList
        {
            get { return data.CurrenciesList; }
        }
        public ObservableCollection<Informants> InformantsList
        {
            get { return data.InformantsList; }
        }
        public ObservableCollection<Logs> LogsList
        {
            get { return data.LogsList; }
        }
        public ObservableCollection<Nationalities> NationalitiesList
        {
            get { return data.NationalitiesList; }
        }
        public ObservableCollection<ObservantGroups> ObservantGroupsList
        {
            get { return data.ObservantGroupsList; }
        }
        public ObservableCollection<Observants> ObservantsList
        {
            get { return data.ObservantsList; }
        }
        public ObservableCollection<Observations> ObservationsList
        {
            get { return data.ObservationsList; }
        }
        public ObservableCollection<Payments> PaymentsList
        {
            get { return data.PaymentsList; }
        }
        public ObservableCollection<Persons> PersonsList
        {
            get { return data.PersonsList; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        // Update data if data has changed
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // All methods for calling methods in data
        #region Agents Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tmp"></param>
        public void AddAgent(Agents tmp)
        {
            data.AddAgent(tmp);
            OnPropertyChanged("AgentsList");
        }
        public void UpdateAgent(Agents tmp)
        {
            data.UpdateAgent(tmp);
            OnPropertyChanged("AgentsList");
        }
        public void RemoveAgent(Agents tmp)
        {
            data.RemoveAgent(tmp);
            OnPropertyChanged("AgentsList");
        }
        #endregion

        #region Informants
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tmp"></param>
        public void AddInformant(Informants tmp)
        {
            data.AddInformant(tmp);
            OnPropertyChanged("InformantsList");
        }
        public void UpdateInformant(Informants tmp)
        {
            data.UpdateInformant(tmp);
            OnPropertyChanged("InformantsList");
        }
        public void RemoveInformant(Informants tmp)
        {
            data.RemoveInformant(tmp);
            OnPropertyChanged("InformantsList");
        }
        #endregion

        #region Observants
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tmp"></param>
        public void AddObservant(Observants tmp)
        {
            data.AddObservant(tmp);
            OnPropertyChanged("ObservantsList");
        }
        public void UpdateObservant(Observants tmp)
        {
            data.UpdateObservant(tmp);
            OnPropertyChanged("ObservantsList");
        }
        public void RemoveObservant(Observants tmp)
        {
            data.RemoveObservant(tmp);
            OnPropertyChanged("ObservantsList");
        }
        #endregion

        #region Persons
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tmp"></param>
        public void AddPerson(Persons tmp)
        {
            data.AddPerson(tmp);
            OnPropertyChanged("PersonsList");
        }
        public void UpdatePerson(Persons tmp)
        {
            data.UpdatePerson(tmp);
            OnPropertyChanged("PersonsList");
        }
        public void RemovePerson(Persons tmp)
        {
            data.RemovePerson(tmp);
            OnPropertyChanged("PersonsList");
        }
        #endregion

        #region Logs
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tmp"></param>
        public void AddLog(Logs tmp)
        {
            data.AddLog(tmp);
            OnPropertyChanged("LogsList");
        }
        #endregion

        #region ObservantGroups
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tmp"></param>
        public void AddObservantGroup(ObservantGroups tmp)
        {
            data.AddObservantGroup(tmp);
            OnPropertyChanged("ObservantGroupsList");
        }
        public void UpdateObservantGroup(ObservantGroups tmp)
        {
            data.UpdateObservantGroup(tmp);
            OnPropertyChanged("ObservantGroupsList");
        }
        public void RemoveObservantGroup(ObservantGroups tmp)
        {
            data.RemoveObservantGroup(tmp);
            OnPropertyChanged("ObservantGroupsList");
        }
        #endregion

        #region Payments

        public void AddPayment(Payments tmp)
        {
            data.AddPayment(tmp);
            OnPropertyChanged("PaymentsList");
        }
        public void UpdatePayment(Payments tmp)
        {
            data.UpdatePayment(tmp);
            OnPropertyChanged("PaymentsList");
        }
        public void RemovePayment(Payments tmp)
        {
            data.RemovePayment(tmp);
            OnPropertyChanged("PaymentsList");
        }
        #endregion

        #endregion
    }
}
