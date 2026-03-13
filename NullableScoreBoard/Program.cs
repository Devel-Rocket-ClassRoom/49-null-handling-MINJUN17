using System;

int?[] scores = { 3, null, 7, null, 5 };
int count = 0;
int sum = 0;
for(int i = 1; i <= scores.Length; i++)
{
    Console.Write($"경기 {i}: ");
    if( scores[i-1].HasValue)
    {
        Console.WriteLine($"{scores[i-1]}점 (진행 완료)");
        count++;
        sum += scores[i-1].Value;
    }
    else
    {
        Console.WriteLine("미진행");
    }
}

Console.WriteLine("\n===전체 점수 (미진행 = -1) ===");
for (int i = 1; i <= scores.Length; i++)
{
    Console.WriteLine($"경기 {i}: {scores[i-1].GetValueOrDefault(-1)}");
}
double avg = sum / (double)count;
Console.WriteLine("=== 통계 ===");
Console.WriteLine($"진행된 경기 수: {count}");
Console.WriteLine($"총점: {sum}");
Console.WriteLine($"평균: {avg:f1}");