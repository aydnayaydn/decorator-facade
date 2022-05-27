public static class FacadeApp{
    public static void Run(){
        var seach = new SearchEngineFacade();
        var result = seach.GetSearchingResults("query");
        Console.WriteLine(result);
    }
}