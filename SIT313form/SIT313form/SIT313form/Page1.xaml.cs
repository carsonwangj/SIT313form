using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SIT313form
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : TabbedPage
	{
		public Page1 ()
		{
			InitializeComponent ();

            MainListView.ItemsSource = new List<Game>
             {
                    new Game
                    {
                        Company = "EA",
                        game = "FIFA, Need For Speed, ANTHEM, BattleField, The SIMS"
                    },      
                    
                    new Game
                    {
                        Company = "2K Sport",
                        game = "NBA 2K, WWE2K, World of Warcraft, Civilization, The Darkness"
                    },
                    
                    new Game
                    {
                        Company = "UbiSoft",
                        game = "Wactch Dog, Assassin's Creed, Call of Duty, Far Cry"
                    },
                    
                    new Game
                    {
                        Company = "CD projekt",
                        game = "The Witcher, Gwent: The Witcher Card Game, Cyberpunk 2077"
                    }

             };
        }
        List<string> games = new List<string>
        {
            "FIFA", "NBA2K", "WatchDog", "The Witcher", "Batman: The Telltale Series", "Game of Thrones", "The Walking Dead: Season One", "Bayonetta", "Dead Rising 2: Off The Record",
            "Dota 2", "League of Legends", "Smite", "Black Desert Online", "World of Warcraft"
        };

        private void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var keyword = GameName.Text;
            var suggestions = games.Where(c => c.ToLower().Contains(keyword.ToLower()));
            //var s = from c in games where c.Contains(keyword) select c;
            SuggestionList.ItemsSource = suggestions;
        }
    }

        //void GameName_SearchButtonPressed(object sender, EventArgs e)
        //{}
}