using System;
using System.Collections.ObjectModel;

namespace HubTile_Data_Binding
{
    /// <summary>
    /// Represents a standard  ViewModel
    /// </summary>
    public class ViewModel
    {
        /// <summary>
        ///  //Maintains a collection of items to be populated into the items source
        /// </summary>
        private ObservableCollection<Model> items;

        /// <summary>
        /// Initialize the instance of <see cref="ViewModel"/>class
        /// </summary>
        public ViewModel()
        {
            Items = new ObservableCollection<Model>();
            PopulateItems();
        }

        /// <summary>
        /// Gets or sets a collection of items to be populated into items source<see cref="ViewModel"/>class
        /// </summary>
        public ObservableCollection<Model> Items
        {
            get { return items; }
            set { items = value; }
        }

        /// <summary>
        /// Method to populate elements of hub tile
        /// </summary>
        private void PopulateItems()
        {

            Model hub1 = new Model { Header = "Mail", ImageSource = @"/Assets/New Mail.png", Interval = TimeSpan.FromSeconds(3.0) };
            Model hub2 = new Model { Header = "Word", ImageSource = @"/Assets/Word.png", Interval = TimeSpan.FromSeconds(3.0) };
            Model hub3 = new Model { Header = "Paint", ImageSource = @"/Assets/Painting Brush.png", Interval = TimeSpan.FromSeconds(3.0) };
            Model hub4 = new Model { Header = "NotePad", ImageSource = @"/Assets/Note.png", Interval = TimeSpan.FromSeconds(3.0) };
            Model hub5 = new Model { Header = "Microsoft Store ", ImageSource = @"/Assets/Store.png", Interval = TimeSpan.FromSeconds(3.0) };
            Model hub6 = new Model { Header = "Clock", ImageSource = @"/Assets/Clock.png", Interval = TimeSpan.FromSeconds(3.0) };
            Model hub7 = new Model { Header = "Calculator", ImageSource = @"/Assets/Calculator.png", Interval = TimeSpan.FromSeconds(3.0) };
            Model hub8 = new Model { Header = "Excel", ImageSource = @"/Assets/Excel.png", Interval = TimeSpan.FromSeconds(3.0) };
            Model hub9 = new Model { Header = "Microsoft Edge", ImageSource = @"/Assets/MicroSoft Edge.png", Interval = TimeSpan.FromSeconds(3.0) };

            Items.Add(hub1);
            Items.Add(hub2);
            Items.Add(hub3);
            Items.Add(hub4);
            Items.Add(hub5);
            Items.Add(hub6);
            Items.Add(hub7);
            Items.Add(hub8);
            Items.Add(hub9);
        }
    }
}

