using System;

string userSetName = null;
string profileSetName = "프로필유저";
string globalSetName = null;
string defaultSetName = "Player";
string finalName = userSetName ?? profileSetName ?? globalSetName ?? defaultSetName;

string userSetServer = null;
string profileSetServer = null;
string globalSetServer = null;
string defaultSetServer = "localhost";
string finalServer = userSetServer ?? profileSetServer ?? globalSetServer ?? defaultSetServer;

string userSetLanguage = "English";
string profileSetLanguage = "Korean";
string globalSetLanguage = "Japanese";
string defaultSetLanguage = "Korean";
string finalLanguage = userSetLanguage ?? profileSetLanguage ?? globalSetLanguage ?? defaultSetLanguage;

int? userSetVolume = null;
int? profileSetVolume = null;
int? globalSetVolume = 70;
int? defaultSetVolume = 50;
int? finalVolume = userSetVolume ?? profileSetVolume ?? globalSetVolume ?? defaultSetVolume; ;

Console.WriteLine("=== 설정 결정 ===");
Console.WriteLine($"플레이어 이름: {finalName} (프로필 설정에서 가져옴)");
Console.WriteLine($"서버 주소: {finalServer} (기본값에서 가져옴)");
Console.WriteLine($"언어: {finalLanguage} (사용자 설정에서 가져옴)");
Console.WriteLine($"볼륨: {finalVolume} (전역 설정에서 가져옴)");

string cacheName = null;
Console.WriteLine("\n=== 캐시 저장 (??=) ===");
Console.WriteLine($"캐시 저장 전: {cacheName ?? "null"}");
cacheName ??= finalName;
Console.WriteLine($"첫 번째 ??= 적용 후: {cacheName}");
cacheName ??= defaultSetName;
Console.WriteLine($"두 번째 ??= 적용 후: {cacheName}");

string cacheServer = null;
string cacheLanguage = null;
int? cacheVolume = null;

cacheServer ??= finalServer;
cacheLanguage ??= finalLanguage;
cacheVolume ??= finalVolume ;
Console.WriteLine("\n=== 최종 설정 ===");
Console.WriteLine($"플레이어 이름: {cacheName}");
Console.WriteLine($"서버 주소: {cacheServer}");
Console.WriteLine($"언어: {cacheLanguage}");
Console.WriteLine($"볼륨: {cacheVolume}");

