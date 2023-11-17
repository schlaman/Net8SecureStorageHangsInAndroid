# Net8SecureStorageHangsInAndroid
This will hang in the splash screen on .NET 8 when deployed to a physical Android device. Tried it on Android 13 on Samsung S9 Ultra SM-X910 tablet and Samsun Galaxy S22 phone.

`app.xaml.cs`
    // This line of code never returns - it hangs forever
    var password = `SecureStorage.GetAsync`("password").Result;

