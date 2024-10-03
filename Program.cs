namespace Session07;

public class EasyPeasy
{   
    public string?
    
    public int Num = 100;

    public EasyPeasy()
    {

    }

    public EasyPeasy(int increment)
    {
        Num += increment;
    }
}
public class Program
{
    public static void Main()
    {
        MusicPlayer musicPlayer = new();

        Playlist playlistElectronic = new();
        Playlist playlistClassicRock = new();

        Song songElctronic1 = new("Dead Stars", "Covenant", "EBM", 336);
        Song songElctronic2 = new("I Stand Alone", "Covenant", "EBM", 430);
        Song songClassicRock1 = new("Dust In The Wind", "Kansas", "Classic Rock", 630);
        Song songClassicRock2 = new("Dust In The Wind", "Kansas", "Classic Rock", 437);

        playlistElectronic.Name = "Electonic Playlist";
        playlistElectronic.Songs.Add(songElctronic1);
        playlistElectronic.Songs.Add(songElctronic2);
        playlistClassicRock.Songs.Add(songClassicRock1);

        musicPlayer.Play(playlistClassicRock);
        musicPlayer.Play(playlistElectronic);
        musicPlayer.Play(playlistElectronic);
        musicPlayer.Play(playlistClassicRock);
        //musicPlayer.Play(playlistElectronic);
    }
}
