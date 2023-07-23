public async Task<string> GetWebContentAsync(string url) {
    using (HttpClient client = new HttpClient()) {
        string content = await client.GetStringAsync(url);
        return content;
    }
}

public async Task CallWebContent() {
    string content = await GetWebContentAsync("https://www.example.com");
    Console.WriteLine(content);
}
