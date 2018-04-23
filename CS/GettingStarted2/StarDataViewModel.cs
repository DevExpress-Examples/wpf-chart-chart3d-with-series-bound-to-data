using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Resources;

namespace GettingStarted2 {
    public class StarStatisticsViewModel {
        public IEnumerable<Star> Stars { get; private set; }

        public StarStatisticsViewModel() {
            Stars = StarStatisticsLoader.Load("/Data/starsdata.csv");
        }
    }

    static class StarStatisticsLoader {
        public static IEnumerable<Star> Load(string filepath) {
            StreamResourceInfo streamInfo = Application.GetResourceStream(
                new Uri(filepath, UriKind.RelativeOrAbsolute)
            );
            StreamReader reader = new StreamReader(streamInfo.Stream);
            Collection<Star> stars = new Collection<Star>();
            while (!reader.EndOfStream) {
                String dataLine = reader.ReadLine();
                String[] serializedValues = dataLine.Split(';');
                stars.Add(
                    new Star(
                        id: Convert.ToInt32(serializedValues[0], CultureInfo.InvariantCulture),
                        x: Convert.ToDouble(serializedValues[3], CultureInfo.InvariantCulture),
                        y: Convert.ToDouble(serializedValues[4], CultureInfo.InvariantCulture),
                        z: Convert.ToDouble(serializedValues[5], CultureInfo.InvariantCulture),
                        spectr: serializedValues[1],
                        luminocity: Convert.ToDouble(serializedValues[6], CultureInfo.InvariantCulture),
                        colorIndex: Convert.ToDouble(serializedValues[2], CultureInfo.InvariantCulture)
                    )
                );
            }

            return stars;
        }
    }
}
