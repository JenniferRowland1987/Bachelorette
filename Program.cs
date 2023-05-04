﻿Dictionary<string, int> locations = new Dictionary<string, int>()

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
}

    string placeVote = Console.ReadLine();

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

bool doneVotingActivity = false;

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