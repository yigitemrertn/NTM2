using NoteToMusic.Entities;
using System;

namespace NoteToMusic.Services
{
    /// <summary>
    /// Feedback işlemlerini yöneten servis
    /// Bu sınıf artık kullanılmıyor - Feedback yönetimi Supabase üzerinden yapılıyor (SupabaseClient)
    /// </summary>
    [Obsolete("Bu sınıf artık kullanılmıyor. SupabaseClient kullanın.")]
    public static class SFeedback
    {
        // Bu sınıf eskiden LocalDB kullanıyordu ama artık Supabase'e geçildi
        // Geriye dönük uyumluluk için bırakıldı ama kullanılmamalı
    }
}
