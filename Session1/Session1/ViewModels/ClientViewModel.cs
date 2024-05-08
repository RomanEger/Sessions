using Prism.Commands;
using Prism.Mvvm;

using Repository.Contracts;
using Repository.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1.ViewModels
{
    public class ClientViewModel : BindableBase
    {
        public ClientViewModel(IRepository<Client> repository)
        {
            _repository = repository;
        }

        private readonly IRepository<Client> _repository;

        private Client _client;

        public Client Client
        {
            get => _client;
            set => SetProperty(ref _client, value);
        }

        private IEnumerable<Client> _clients;

        public IEnumerable<Client> Clients
        {
            get => _clients;
            set => SetProperty(ref _clients, value);
        }

        public DelegateCommand GetAllCommand { get; private set; }

    }
}
