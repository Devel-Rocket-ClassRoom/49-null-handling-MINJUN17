using System;
using System.Collections.Generic;

////1-1
//string name = null;
//name ??= "이름 없음";
//Console.WriteLine(name);
//name ??= "새 이름";
//Console.WriteLine(name);

////1-2
//string playerName = null;
//if(playerName == null)
//{
//    playerName = "플레이어";
//}
//Console.WriteLine(playerName);

////1-3
//List<string> _items = null;
//_items ??= new List<string>();
//_items.Add("검");
//_items ??= new List<string>();
//_items.Add("방패");
//Console.WriteLine($"아이템 수: {_items.Count}");
//Console.WriteLine($"- {_items[0]}");
//Console.WriteLine($"- {_items[1]}");

////2-1
//string message = null;
//int? messageLength = message?.Length;
//Console.WriteLine($"길이: {messageLength}");
//message = "안녕하세요";
//messageLength = message?.Length;
//Console.WriteLine($"길이: {messageLength}");

////2-2
//string text = null;
//int? textLength = text?.Length;
//if(textLength == null)
//{
//    Console.WriteLine("텍스트가 없습니다.");
//}

////2-3
//string name = null;
//string upperName = name?.ToUpper();
//Console.WriteLine($"대문자: {upperName}");
//name = "hello";
//upperName = name?.ToUpper();
//Console.WriteLine($"대문자: {upperName}");

////2-4
//string text = null;
//string newText = text?.ToUpper().Trim();
//Console.WriteLine($"결과: {newText}");
//text = "hello";
//newText = text?.ToUpper().Trim();
//Console.WriteLine($"결과: {newText}");

////2-5
//List<string> items = null;
//int? count = items?.Count;
//Console.WriteLine($"아이템 수: {count}");
//items = new List<string>();
//items.Add("사과");
//items.Add("바나나");
//count = items?.Count;
//Console.WriteLine($"아이템 수: {count}");

////2-6
//string text = null;
//char? c = text?[0];
//Console.WriteLine($"첫 글자: {c}");
//text = "Hello";
//c = text?[0];
//Console.WriteLine($"첫 글자: {c}");

////3-1
//string message = null;
//int len = message?.Length ?? 0;
//Console.WriteLine($"길이: {len}");
//message = "Hello";
//len = message?.Length ?? 0;
//Console.WriteLine($"길이: {len}");

////3-2
//List<string> names = null;
//Console.WriteLine($"이름 수: {names?.Count}");
//List<string> names2 = new List<string>(){ "Kim", "Lee", "Park" };
//names = names2;
//Console.WriteLine($"이름 수: {names?.Count}");

//3-3
string playerName = null;
int? playerLevel = null;
List<string> inventory = null;
string displayName = playerName ?? "Unknown";
int level = playerLevel ?? 1;
int itemCount = inventory?.Count ?? 0;
Console.WriteLine($"플레이어: {displayName}");
Console.WriteLine($"레벨: {level}");
Console.WriteLine($"인벤토리 아이템: {itemCount}개");