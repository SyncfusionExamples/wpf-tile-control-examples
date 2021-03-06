using System;
using System.Collections.ObjectModel;
using Syncfusion.Windows.Shared;

namespace PulsingTile_Getting_Started
{
    /// <summary>
    /// Class represents the behaviour or business logic for MainWindow.xaml
    /// </summary>
    public class ViewModel : NotificationObject
    {
        /// <summary>
        /// Maintains a collection for pulse scale
        /// </summary>
        private ObservableCollection<double> pulseScale;

        /// <summary>
        /// Maintains a collection for pulse duration
        /// </summary>
        private ObservableCollection<TimeSpan> pulseDuration;

        /// <summary>
        /// Initalize the instance of <see cref="ViewModel"/> class
        /// </summary>
        public ViewModel()
        {
            PulseScale = new ObservableCollection<double>();
            PulseDuration = new ObservableCollection<TimeSpan>();
            Additems();
        }

        /// <summary>
        /// Gets or sets the collection for pulse scale<see cref="ViewModel"/>class.
        /// </summary>
        public ObservableCollection<double> PulseScale
        {
            get { return pulseScale; }
            set
            {
                pulseScale = value;
                RaisePropertyChanged("PulseScale");
            }
        }

        /// <summary>
        /// Gets or sets the collection for pulse duration<see cref="ViewModel"/>class.
        /// </summary>
        public ObservableCollection<TimeSpan> PulseDuration
        {
            get { return pulseDuration; }
            set
            {
                pulseDuration = value;
                RaisePropertyChanged("PulseDuration");
            }
        }

        /// <summary>
        /// Method to populate elements of pulsing tile
        /// </summary>
        private void Additems()
        {
            for (double i = 1; i <= 5; i++)
            {
                PulseScale.Add(i);
            }
            for (double i = 1; i <= 8; i++)
            {
                PulseDuration.Add(TimeSpan.FromSeconds(i));
            }
        }
    }
}
