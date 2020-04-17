using System;

namespace HubTile_Data_Binding
{
    /// <summary>
    /// Represents a standard  model
    /// </summary>
    public class Model
    {
        /// <summary>
        /// Represents the header to be displayed in hub tile
        /// </summary>
        private string header;

        /// <summary>
        /// Represents the image path for image in the hub tile
        /// </summary>
        private string imageSource;

        /// <summary>
        /// Represents the interval for the hub tile
        /// </summary>
        private TimeSpan interval;

        /// <summary>
        /// Gets or sets the header to be displayed in the Hub Tile<see cref="Model"/>calss
        /// </summary>
        public string Header
        {
            get { return header; }
            set { header = value; }
        }

        /// <summary>
        /// Gets or sets the image path for the image to be displayed in the Hub Tile<see cref="Model"/>class
        /// </summary>
        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; }
        }

        /// <summary>
        /// Gets or sets the interval for the Hub Tile<see cref="Model"/>class
        /// </summary>
        public TimeSpan Interval
        {
            get { return interval; }
            set { interval = value; }
        }
    }
}

