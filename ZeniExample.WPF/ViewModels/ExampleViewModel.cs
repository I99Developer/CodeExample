using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZeniExample.Core.Models.HumanResources;

namespace ZeniExample.WPF.ViewModels
{
    public class ExampleViewModel : INotifyPropertyChanged
    {
        HttpClient m_ExampleClient;
        string m_Url;
       
        private List<Department> m_Departments;
        private ICommand m_GetDepartmentsCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand GetDepartmentsCommand
        {
            get
            {
                if (null != m_GetDepartmentsCommand)
                    return m_GetDepartmentsCommand;

                m_GetDepartmentsCommand = new CommandHandler(() => GetDepartments());
                return m_GetDepartmentsCommand;
            }
        }

        public List<Department> Departments { get => m_Departments; set { m_Departments = value; RaisePropertyChanged("Departments"); } }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void GetDepartments()
        {
            m_ExampleClient = new HttpClient();

            m_Url = ConfigurationManager.AppSettings["ApiUrl"].ToString();

            m_ExampleClient.BaseAddress = new Uri(m_Url);

            HttpResponseMessage response = await m_ExampleClient.GetAsync(m_Url);

            if (response.IsSuccessStatusCode)
            {
                var retVal = response.Content.ReadAsStringAsync().Result;
                Departments = JsonConvert.DeserializeObject<List<Department>>(retVal);
            }
        }
    }

    public class CommandHandler : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action m_HandlerAction;
        public CommandHandler(Action action) { m_HandlerAction = action; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            m_HandlerAction.Invoke();
        }
    }
}
