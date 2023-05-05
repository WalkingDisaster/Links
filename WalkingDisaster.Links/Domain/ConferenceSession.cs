namespace WalkingDisaster.Links.Domain;

public readonly record struct ConferenceSession(string Conference, int Year, string BaseUrl, string? SlidesUrl, string? CodeUrl, string? VideoUrl);