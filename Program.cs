Dictionary<string, int> locations = new Dictionary<string, int>(){    {"Cabo", 0},    {"Las Vegas", 0 },    {"New York", 0 },    {"Detroit", 0 },    {"Toronto", 0 },};Dictionary<string, int> activities = new Dictionary<string, int>(){    {"Beach time", 0},    {"Pub crawl", 0 },    {"Go bowling", 0 },    {"Visit a museum", 0 },    {"Go to a show", 0 },};Console.WriteLine("Our choices for locations to visit are:");foreach (string place in locations.Keys){    Console.WriteLine(place);}

static bool votingComplete()
{
    Console.WriteLine("Press enter for next voter, or 'done' to exit");
    string input = Console.ReadLine();

    if (input == "done")
    {
        Console.WriteLine("Thanks for voting");
        return true;
    }
    else
    { return false; }
}bool doneVotingLocation = false;int caboVotes = 0;int lasVegasVotes = 0;int newYorkVotes = 0;int detroitVotes = 0;int torontoVotes = 0;while (doneVotingLocation == false){    Console.WriteLine("Please vote for the location you'd like to visit:");

    string placeVote = Console.ReadLine();    if (placeVote == "Cabo")    {        caboVotes = caboVotes +1;

        doneVotingLocation = votingComplete();
    }
    else if (placeVote == "Las Vegas")
    {
        lasVegasVotes = lasVegasVotes + 1;

        doneVotingLocation = votingComplete();
    }
    else if (placeVote == "New York")
    {
        newYorkVotes = newYorkVotes + 1;

        doneVotingLocation = votingComplete();
    }
    else if (placeVote == "Detroit")
    {
        detroitVotes = detroitVotes + 1;

        doneVotingLocation = votingComplete();
    }
    else if (placeVote == "Toronto")
    {
        torontoVotes = torontoVotes + 1;

        doneVotingLocation = votingComplete();
    }   
}

locations["Cabo"] = caboVotes;
locations["Las Vegas"] = lasVegasVotes;
locations["Detroit"] = detroitVotes;
locations["New York"] = newYorkVotes;
locations["Toronto"] = torontoVotes;

Console.WriteLine("The votes are in!");
Console.WriteLine("......");
foreach (KeyValuePair <string, int> item in locations)
{
    Console.WriteLine(item.Value + " vote for " + item.Key ); ;
}

bool doneVotingActivity = false;int beachVotes = 0;int pubVotes = 0;int bowlingVotes = 0;int museumVotes = 0;int showVotes = 0;Console.WriteLine("Here are the activities we could do:");

foreach (string activity in activities.Keys)
{
    Console.WriteLine(activity);
}

while (doneVotingActivity == false)
{
    Console.WriteLine("Please vote for the activity you'd like to do:");

    string activityVote = Console.ReadLine();

    if (activityVote == "Beach time")
    {
        beachVotes = beachVotes + 1;

        doneVotingActivity = votingComplete();
    }
    else if (activityVote == "Pub crawl")
    {
        pubVotes = pubVotes + 1;

        doneVotingActivity = votingComplete();
    }
    else if (activityVote == "Visit a museum")
    {
        museumVotes = museumVotes + 1;

        doneVotingActivity = votingComplete();
    }
    else if (activityVote == "Go bowling")
    {
        bowlingVotes = bowlingVotes + 1;

        doneVotingActivity = votingComplete();
    }
    else if (activityVote == "Go to a show")
    {
        showVotes = showVotes + 1;

        doneVotingActivity = votingComplete();
    }
}
activities["Beach time"] = beachVotes;
activities["Pub crawl"] = pubVotes;
activities["Go bowling"] = bowlingVotes;
activities["Visit a museum"] = museumVotes;
activities["Go to a show"] = showVotes;

Console.WriteLine("The votes are in!");
Console.WriteLine("......");
foreach (KeyValuePair<string, int> item in activities)
{
    Console.WriteLine(item.Value + " vote for " + item.Key); ;
}