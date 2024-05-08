using Repository.Contracts;
using Repository.Entities;

using System.Windows;

namespace Session1
{
    public partial class MainWindow : Window
    {
        private readonly IRepository<Client> _repository;

        public MainWindow(IRepository<Client> repository)
        {
            InitializeComponent();

            _repository = repository;
            
        }
    }
}
