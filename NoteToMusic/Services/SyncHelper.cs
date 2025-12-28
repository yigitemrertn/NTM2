using NoteToMusic.Entities;
using NoteToMusic.Services;
using System;
using System.Threading.Tasks;

namespace NoteToMusic.Services
{
    /// <summary>
    /// Cloud sync helper - SQL Server'dan Supabase'e toplu sync
    /// Bu sınıf artık kullanılmıyor çünkü LocalDB kaldırıldı - Tüm feedback'ler direkt Supabase'e gidiyor
    /// </summary>
    [Obsolete("Bu sınıf artık kullanılmıyor. Feedback'ler direkt SupabaseClient ile gönderiliyor.")]
    public static class SyncHelper
    {
        // Bu sınıf eskiden LocalDB → Supabase sync yapıyordu
        // LocalDB kaldırıldığı için artık gereksiz
    }
}
