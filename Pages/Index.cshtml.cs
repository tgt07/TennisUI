using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tennis_ui.Pages;

public class IndexModel : PageModel
{
    public List<PlayerPerformance> PlayerPerformances = new List<PlayerPerformance>();
    public List<NationalRanking> NationalRankings = new List<NationalRanking>();
    public List<PlayersMeetingTournamentGuideline> PlayersMeetingTournamentGuidelines = new List<PlayersMeetingTournamentGuideline>();
    public List<WPDPCoachCertification> WPDPCoachCertifications = new List<WPDPCoachCertification>();
    public List<Player> Players = new List<Player>();
    public List<Coach> Coaches = new List<Coach>();
    public void OnGet()
    {
        PlayerPerformances = new List<PlayerPerformance>
        {
            new PlayerPerformance
            {
                Tournament = "Australian Open",
                TournamentDisplay = "Australian Open",
                Results = "Winner",
                PointsPerPlayer = "2000",
                PointsAchieved = 2000,
                TDCMemID = 1,
                Year = 2021
            },
            new PlayerPerformance
            {
                Tournament = "French Open",
                TournamentDisplay = "French Open",
                Results = "Winner",
                PointsPerPlayer = "2000",
                PointsAchieved = 2000,
                TDCMemID = 1,
                Year = 2021
            },
            new PlayerPerformance
            {
                Tournament = "Wimbledon",
                TournamentDisplay = "Wimbledon",
                Results = "Winner",
                PointsPerPlayer = "2000",
                PointsAchieved = 2000,
                TDCMemID = 1,
                Year = 2021
            },
            new PlayerPerformance
            {
                Tournament = "US Open",
                TournamentDisplay = "US Open",
                Results = "Winner",
                PointsPerPlayer = "2000",
                PointsAchieved = 2000,
                TDCMemID = 1,
                Year = 2021
            }
        };

        NationalRankings = new List<NationalRanking>
        {
            new NationalRanking
            {
                Category = "U12" ,
                CategoryDisplay = "National Ranking",
                Ranking = "Top 10",
                PointsPerPlayer = "1000",
                PointsAchieved = 1000,
                TDCMemID = 1,
                Year = 2021,
                ResultsValue = "10",
            },

            new NationalRanking
            {
                Category = "U12" ,
                CategoryDisplay = "National Ranking",
                Ranking = "Top 10",
                PointsPerPlayer = "1000",
                PointsAchieved = 1000,
                TDCMemID = 1,
                Year = 2021,
                ResultsValue = "10",
            },

        };

        PlayersMeetingTournamentGuidelines = new List<PlayersMeetingTournamentGuideline>
        {
            new PlayersMeetingTournamentGuideline
            {
                Category = "U12" ,
                CategoryDisplay = "National Ranking",
                Guideline = "Top 10",
                PointsPerPlayer = "1000",
                PointsAchieved = 1000,
                TDCMemID = 1,
            },

            new PlayersMeetingTournamentGuideline            {
                Category = "U12" ,
                CategoryDisplay = "National Ranking",
                Guideline = "Top 10",
                PointsPerPlayer = "1000",
                PointsAchieved = 1000,
                TDCMemID = 1,
            },

        };

        WPDPCoachCertifications = new List<WPDPCoachCertification>
        {
            new WPDPCoachCertification
            {
                TDCMemID = 1,
                CertificationLevel = "Level 1",
                PointsPerCoach = "100 points"
            },
            new WPDPCoachCertification
            {
                TDCMemID = 1,
                CertificationLevel = "Level 2",
                PointsPerCoach = "200 points"
            },
            new WPDPCoachCertification
            {
                TDCMemID = 1,
                CertificationLevel = "Level 3",
                PointsPerCoach = "300 points"
            }
        };

        Players = new List<Player>
        {
            new Player
            {
                TournamentPlayerId = "1",
                PlayerName = "Roger Federer",
                Birthday = "08/08/1981",
                DateAdded = "08/08/1981"
            },
            new Player
            {
                TournamentPlayerId = "2",
                PlayerName = "Rafael Nadal",
                Birthday = "08/08/1981",
                DateAdded = "08/08/1981"
            },
            new Player
            {
                TournamentPlayerId = "3",
                PlayerName = "Novak Djokovic",
                Birthday = "08/08/1981",
                DateAdded = "08/08/1981"
            }
        };

        Coaches = new List<Coach>
        {
            new Coach
            {
                NCCP = "1",
                CoachName = "Coach 1",
                CertificationLevel = "Level 1",
                DateAdded = "08/08/1981"
            },
            new Coach
            {
                NCCP = "2",
                CoachName = "Coach 2",
                CertificationLevel = "Level 2",
                DateAdded = "08/08/1981"
            },
            new Coach
            {
                NCCP = "3",
                CoachName = "Coach 3",
                CertificationLevel = "Level 3",
                DateAdded = "08/08/1981"
            }
        };

       

    }

   

    public class PlayerPerformance {
    public required string Tournament { get; set; }
        public required string TournamentDisplay { get; set; }
        public required string Results { get; set; }
        public required string PointsPerPlayer { get; set; }
        public required int PointsAchieved { get; set; }
        public required int TDCMemID { get; set; }
        public required int Year { get; set; }
    }

    public class PlayerPerformanceDetails {
        public required string PlayerName { get; set; }

    }

    public class NationalRanking
    {
        public required string Category { get; set; }
        public required string CategoryDisplay { get; set; }
        public required string Ranking { get; set; }
        public required string ResultsValue { get; set; }
       
        public required string PointsPerPlayer { get; set; }
        public required int PointsAchieved { get; set; }
        public required int TDCMemID { get; set; }
        public required int Year { get; set; }
    }

    public  class NationalRankingDetails {
        public required string PlayerName { get; set; }
        public required string Cat { get; set; }
        public required string Rank { get; set; }
    }

    public class PlayersMeetingTournamentGuideline
    {
        public required string Category { get; set; }
        public required string CategoryDisplay { get; set; }
        public required string Guideline { get; set; }
        public required string PointsPerPlayer { get; set; }
        public required int PointsAchieved { get; set; }
        public required int TDCMemID { get; set; }
    }

    public class PlayersMeetingTournamentGuidelinesDetails
    {
        public required string PlayerName { get; set; }
        public required string Points { get; set; }
        public required int NumofTournaments { get; set; }
        public required string MemberID { get; set; }
    }

    public class WPDPCoachCertification
    {
        public required int TDCMemID { get; set; }
        public required string CertificationLevel { get; set; }
        public required string PointsPerCoach { get; set; }
        public int PointsPerCoachValue
        {
            get
            {
                return Convert.ToInt32(PointsPerCoach.Replace(" points", ""));
            }
        }
    }

    public class WPDPCoachCertificationDetails
    {
        public required string PlayerName { get; set; }
        public required string CertificationLevel { get; set; }
    }

    public class TotalFundingAchieved {
        public required string Section { get; set; }
        public required int Total_Points { get; set; }
    }

    public class Player {
        public required string TournamentPlayerId { get; set; }
        public required string PlayerName { get; set; }
        public required string Birthday { get; set; }
        public required string DateAdded { get; set; }
    }

    public class Coach
     {
        public required string NCCP { get; set; }
        public required string CoachName { get; set; }
        public required string CertificationLevel { get; set; }
        public required string DateAdded { get; set; }
    }
      
}

