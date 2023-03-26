﻿using DBD_ResourcePackManager.Classes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace DBD_ResourcePackManager.UserControls
{
    public partial class CharacterUC : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }

        private Character _characterInfo;
        public Character CharacterInfo
        {
            get => _characterInfo;
            set
            {
                _characterInfo = value;
                Visibility = 0;
                NotifyPropertyChanged();
            }
        }

        public CharacterUC()
        {
            InitializeComponent();
        }
    }
}
