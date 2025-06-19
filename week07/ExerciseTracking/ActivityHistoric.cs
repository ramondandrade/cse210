class ActivityHistory
{
    private List<Activity> _activities = new List<Activity>();

    public void AddActivity(Activity activity) => _activities.Add(activity);

    public void ShowAllSummaries()
    {
        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}