using System;

namespace FunWithMusic
{
    class Program

    {
        // Music genre enum
        public enum MusicGenre
        {
            Rock,
            Pop,
            HipHop,
            Jazz,
            Electronic
        }

        // Music structure
        public struct Music
        {
            // Variables
            public string Title;
            public string Artist;
            public string Album;
            public TimeSpan Length;
            public MusicGenre Genre;

            // Constructor
            public Music(string title, string artist, string album, TimeSpan length, MusicGenre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            // Display method
            public void Display()
            {
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Artist: {Artist}");
                Console.WriteLine($"Album: {Album}");
                Console.WriteLine($"Length: {Length}");
                Console.WriteLine($"Genre: {Genre}");
            }
            // Set method for Title
            public void SetTitle(string title)
            {
                this.Title = title;
            }

            // Set method for Length
            public void SetLength(TimeSpan length)
            {
                this.Length = length;
            }
            // Set method for Artist
            public void SetArtist(string artist)
            {
                this.Artist = artist;
            }

            // Set method for Album
            public void SetAlbum(string album)
            {
                this.Album = album;
            }

            // Set method for Genre
            public void SetGenre(MusicGenre genre)
            {
                this.Genre = genre;
            }
        }

            static void Main(string[] args)
            {
                // Prompting user for music information
                Console.WriteLine("How many songs would you like to enter?");
                int size = int.Parse(Console.ReadLine());
                Music[] collection = new Music[size];
                try
                {
                    for (int i = 0; i < size; i++)
                    {
                        // Prompting for song information
                        Console.WriteLine($"Enter information for song {i + 1}:");
                        Console.Write("Title: ");
                        collection[i].SetTitle(Console.ReadLine());

                        Console.Write("Artist: ");
                        collection[i].SetArtist(Console.ReadLine());

                        Console.Write("Album: ");
                        collection[i].SetAlbum(Console.ReadLine());

                        Console.Write("Length (hh:mm:ss): ");
                        TimeSpan length;
                        TimeSpan.TryParse(Console.ReadLine(), out length);

                        Console.WriteLine("Choose genre:");
                        Console.WriteLine("R - Rock\nP - Pop\nH - HipHop\nJ - Jazz\nE - Electronic");
                        MusicGenre tempGenre = MusicGenre.Rock;
                        char g = char.Parse(Console.ReadLine());
                        switch (g)
                        {
                            case 'R':
                                tempGenre = MusicGenre.Rock;
                                break;
                            case 'P':
                                tempGenre = MusicGenre.Pop;
                                break;
                            case 'H':
                                tempGenre = MusicGenre.HipHop;
                                break;
                            case 'J':
                                tempGenre = MusicGenre.Jazz;
                                break;
                            case 'E':
                                tempGenre = MusicGenre.Electronic;
                                break;
                        }
                        collection[i].SetGenre(tempGenre);
                    }

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    // Printing the collection
                    Console.WriteLine("\nMusic Collection:");
                    for (int i = 0; i < size; i++)
                    {
                    collection[i].Display();
                    }
                }
            }
    }
}
    
