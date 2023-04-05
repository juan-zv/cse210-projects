using System;

class Program
{
    static void Main(string[] args)
    {
        List<Media> mediaList = new List<Media>();
        int userChoice;

        do {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Media Manager program by Juan Zurita");
            Console.WriteLine("The program has a sample library you can use. It is called 'pre-created-library'");
            Console.WriteLine("Select what do you want to do:");
            Console.WriteLine("\t1. Add new element to the library");
            Console.WriteLine("\t2. See available media");
            Console.WriteLine("\t3. Edit element");
            Console.WriteLine("\t4. Organize element");
            Console.WriteLine("\t5. Share library");
            Console.WriteLine("\t6. Upload library");
            Console.WriteLine("\t7. Quit");
            userChoice = int.Parse(Console.ReadLine());


            if (userChoice == 1){

                Console.WriteLine("What type of media do you want to add?");
                Console.WriteLine("\t1. Entire Song Album");
                Console.WriteLine("\t2. Song");
                Console.WriteLine("\t3. Photo");
                Console.WriteLine("\t4. Video");
                Console.WriteLine("\t5. E-book");
                Console.WriteLine("\t6. Document");
                int mediaType = int.Parse(Console.ReadLine());
                if (mediaType == 1){
                    Console.WriteLine("What is the name of the song album?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Who is the artist?");
                    string author = Console.ReadLine();
                    Console.WriteLine("What other artists are there in the album?(Separate them by dashes or dots, not commas)");
                    string otherArtists = Console.ReadLine();
                    Console.WriteLine("Do you want to add songs to the album?(Yes/No)");
                    
                    Album newAlbum = new Album("Album", name, author, otherArtists);
                    mediaList.Add(newAlbum);
                }
                else if (mediaType == 2){
                    Console.WriteLine("What is the name of the song?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Who is the artist?");
                    string author = Console.ReadLine();
                    Console.WriteLine("What other artists are there in the song?(Just press enter if the song has just one artist)");
                    string otherArtists = Console.ReadLine();
                    Console.WriteLine("What is the duration of the song?");
                    int length = int.Parse(Console.ReadLine());

                    Song newSong = new Song("Song", name, author, otherArtists, length);
                    mediaList.Add(newSong);
                }
                else if (mediaType == 3){
                    Console.WriteLine("What is the title for the picture?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Who took the picture?");
                    string author = Console.ReadLine();
                    Console.WriteLine("Where did you take the picture?");
                    string location = Console.ReadLine();
                    Console.WriteLine("What camera model did you use?");
                    string camera = Console.ReadLine();
                    Console.WriteLine("What is the file format?(JPEG, PNG, RAW)");
                    string fileFormat = Console.ReadLine();
                    
                    Photo newPhoto = new Photo("Photo", name, author, location, camera, fileFormat);
                    mediaList.Add(newPhoto);
                }
                else if (mediaType == 4){
                    Console.WriteLine("What is the title for the video?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Who recorded the video?");
                    string author = Console.ReadLine();
                    Console.WriteLine("Where did you record the video?");
                    string location = Console.ReadLine();
                    Console.WriteLine("What camera model did you use?");
                    string camera = Console.ReadLine();
                    Console.WriteLine("What is the file format?(MP4, AVI, MOV, WMV)");
                    string format = Console.ReadLine();
                    Console.WriteLine("How long, in minutes, is the video?");
                    int length = int.Parse(Console.ReadLine());
                    
                    Video newVideo = new Video("Video", name, author, location, camera, format, length);
                    mediaList.Add(newVideo);
                }
                else if (mediaType == 5){
                    Console.WriteLine("What is the name of the book?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Who is the author?");
                    string author = Console.ReadLine();
                    Console.WriteLine("What is the ISBN of the book?(Enter without dashes)");
                    int ISBN = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the genre of the book?");
                    string genre = Console.ReadLine();
                    Console.WriteLine("What is a brief summar of the book?");
                    string summary = Console.ReadLine();
                    
                    Ebook newEbook = new Ebook("e-book", name, author, ISBN, genre, summary);
                    mediaList.Add(newEbook);
                }
                else if (mediaType == 6){
                    Console.WriteLine("What is the title of the document?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Who is the author?");
                    string author = Console.ReadLine();
                    Console.WriteLine("What is a keyword for the document?(If more than one, separate them by dashes)");
                    string keywords = Console.ReadLine();
                    Console.WriteLine("What is the file format?");
                    string fileFormat = Console.ReadLine();
                    Console.WriteLine("What is the language in which the document is written?");
                    string language = Console.ReadLine();
                    
                    Document newDoc = new Document("Document", name, author, keywords, fileFormat, language);
                    mediaList.Add(newDoc);
                }
            }    

            else if (userChoice == 2){
                Console.WriteLine("");
                foreach (Media item in mediaList)
                {
                    item.DisplayMedia();
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

            else if (userChoice == 3){
                int i = 1;

                Console.WriteLine("Which element do you want to edit(delete)?");
                Console.WriteLine("");
                foreach (Media item in mediaList)
                {
                    Console.Write($"{i}. "); item.DisplayMedia();
                    Console.WriteLine("");
                    i++;
                }
                Console.WriteLine("");

                int editChoice = int.Parse(Console.ReadLine()) - 1;

                //select mediaList[editChoice] and do something with it

                mediaList.RemoveAt(editChoice);

                Console.WriteLine("The edit feature is still in a beta so the item will just be deleted and you will hve to create a new one. Thank you :)");
            }

            else if (userChoice == 4){
                int i = 1;

                Console.WriteLine("Which element do you want to organize?");
                Console.WriteLine("");
                foreach (Media item in mediaList)
                {
                    Console.Write($"/t{i}. "); item.DisplayMedia();
                    Console.WriteLine("");
                    i++;
                }
                Console.WriteLine("");

                int editChoice = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("In what order number do you want to put it?");

                int newOrder = int.Parse(Console.ReadLine()) - 1;
                
                Media mediaToMove = mediaList[editChoice];

                mediaList.RemoveAt(editChoice);

                mediaList.Insert(newOrder, mediaToMove);
            }

            else if (userChoice == 5){
                Console.WriteLine("What is the name of the file you want to save the library as?");
                string fileName = Console.ReadLine();

                List<string> mediaDataList = new List<string>();

                foreach (var item in mediaList)
                {
                    mediaDataList.Add(item.MediaData());
                }
                File.WriteAllLines($"{fileName}.txt", mediaDataList);
            }

            else if (userChoice == 6){
                Console.WriteLine("What is the name of the file you want to upload to the library?");
                string fileName = Console.ReadLine();
                string[] mediaDataList = File.ReadAllLines($"{fileName}.txt");

                foreach (var item in mediaDataList)
                {
                    string[] media = item.Split(", ");
                    if (media[0] == "Album"){
                        Album newAlbum = new Album(media[0], media[1], media[2], media[3]);
                        mediaList.Add(newAlbum);
                    }
                    else if (media[0] == "Song"){
                        Song newSong = new Song(media[0], media[1], media[2], media[3], int.Parse(media[4]));
                        mediaList.Add(newSong);
                    }
                    else if (media[0] == "Photo"){
                        Photo newPhoto = new Photo(media[0], media[1], media[2], media[3], media[4], media[5]);
                        mediaList.Add(newPhoto);
                    }
                    else if (media[0] == "Video"){
                        Video newVideo = new Video(media[0], media[1], media[2], media[3], media[4], media[5], int.Parse(media[6]));
                        mediaList.Add(newVideo);
                    }
                    else if (media[0] == "Ebook"){
                        Ebook newBook = new Ebook(media[0], media[1], media[2], int.Parse(media[3]), media[4], media[5]);
                        mediaList.Add(newBook);
                    }
                    else if (media[0] == "Document"){
                        Document newDoc = new Document(media[0], media[1], media[2], media[3], media[4], media[5]);
                        mediaList.Add(newDoc);
                    }
                }

            }

        }
        while (userChoice != 7);
    }
}