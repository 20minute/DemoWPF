using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Headers;
using WpfApp1;

namespace WpfApp1
{
    public class FestivalViewModel : INotifyPropertyChanged
    {

        private Festival Festival = new Festival();
        
        #region Properties


        public string FestivalName
        {
            get { return Festival.Nom; }
            set
            {
                if (Festival.Nom != value)
                {
                    Festival.Nom = value;
                    RaisePropertyChanged("FestivalName");
                }

            }
        }

        public string FestivalDescription
        {
            get { return Festival.Description; }
            set
            {
                if (Festival.Description != value)
                {
                    Festival.Description = value;
                    RaisePropertyChanged("FestivalDescription");
                }
            }
        }
       
        #endregion

        
        public void PostFestivalToAPI(FestivalViewModel FestivalViewModel)
        {
            Festival Fesival = new Festival() { Description = FestivalViewModel.FestivalDescription,
                                                Nom = FestivalViewModel.FestivalName };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:9572/api/festivals");
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

            Task<HttpResponseMessage> postTask = client.PostAsJsonAsync<Festival>("festivals", Festival);
            postTask.Wait();

            HttpResponseMessage result = postTask.Result;
        }
        
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods

        private void RaisePropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region Commands
        void AddFestivalExecute()
        {
            PostFestivalToAPI(new FestivalViewModel() );
    
        }

        bool CanAddFestivalExecute()
        {
            return true;
        }

        public ICommand AddFestival { get { return new RelayCommand(AddFestivalExecute, CanAddFestivalExecute); } }
        #endregion
    }
}
