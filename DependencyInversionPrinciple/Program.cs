// See https://aka.ms/new-console-template for more information
using DependencyInversionPrinciple;

Console.WriteLine("Hello, World!");

SpotifyApi spotifyApi = new SpotifyApi();
spotifyApi.FindAll();

//GOOD PRACTICE
var API1 = new MusicClient(new AppleMusicApi());
API1.GetTracks();
var API2 = new MusicClient(new SpotifyApi());
API2.GetTracks();
