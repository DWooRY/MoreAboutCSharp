# 🧠 C# & .NET Core Geliştirici Bilgi Rehberi

Bu repo, C# ve .NET Core dünyasında kullanılan temel ve ileri düzey konuların kısa açıklamalarını ve örneklerini içeren kapsamlı bir bilgi rehberidir. 

## 🚀 İçindekiler

- [Temel C# Konuları](#temel-c-konuları)
- [Veri İşleme Formatları](#veri-işleme-formatları)
- [Veritabanı ve SQL](#veritabanı-ve-sql)
- [Katmanlı Mimari (N-Layer Architecture)](#katmanlı-mimari-n-layer-architecture)
- [Dosya ve Sistem İşlemleri](#dosya-ve-sistem-işlemleri)
- [Gelişmiş C# Konuları](#gelişmiş-c-konuları)
- [Uygulama Özellikleri](#uygulama-özellikleri)
- [Güvenlik ve Şifreleme](#güvenlik-ve-şifreleme)

---

## ✅ Temel C# Konuları

| Konu | Açıklama |
|------|----------|
| **Error Management** | `try-catch-finally`, custom exception handling |
| **Delegate** | Metot referansları oluşturmak ve olay yönetimi için kullanılır |
| **Local Function** | Bir metodun içinde tanımlanan yardımcı metot |
| **Interpolition** | `$"Merhaba {isim}"` tarzı string birleştirme |
| **Tuple** | Çoklu veri tiplerini tek bir yapıda döndürme |
| **Var** | Türü derleyici tarafından belirlenen değişken |

---

## 🗃️ Veri İşleme Formatları

| Format | Açıklama |
|--------|----------|
| **JSON** | Web API'lerde standart veri formatı |
| **XML** | Eski sistemlerle veri paylaşımı |
| **CSV** | Tablo verisi dışa/İçe aktarma (Excel uyumu) |

---

## 🛢️ Veritabanı ve SQL

| Konu | Açıklama |
|------|----------|
| **SQL Server** | Veritabanı sistemi – T-SQL ile sorgular |
| **LINQ** | Nesne koleksiyonlarında SQL benzeri sorgular |

---

## 🏗️ Katmanlı Mimari (N-Layer Architecture)

Projelerin daha okunabilir, test edilebilir ve sürdürülebilir olması için katmanlara ayrılmış yapıdır:

- `Presentation (UI)`
- `Business Logic Layer (BLL)`
- `Data Access Layer (DAL)`
- `Entities (Model)`
- `Common / Core / Helper Layers`

---

## 📁 Dosya ve Sistem İşlemleri

| Konu | Açıklama |
|------|----------|
| **System.IO** | Dosya okuma/yazma, klasör işlemleri |
| **Registry** | Windows sistem kayıt defteri işlemleri |
| **DLL** | Kod modülleri oluşturma ve farklı projelerde kullanma |

---

## 🧠 Gelişmiş C# Konuları

| Konu | Açıklama |
|------|----------|
| **Dynamic** | Runtime'da veri tipi belirlenebilen değişken |
| **Reflection** | Kod çalışma anında obje ve metot bilgilerine erişim sağlar |

---

## 🛠️ Uygulama Özellikleri

| Konu | Açıklama |
|------|----------|
| **Windows Services** | Arka planda çalışan servis uygulamaları |
| **Email Sending** | SMTP ile e-posta gönderimi (`SmtpClient`) |
| **NLog** | Loglama işlemleri için kullanılan yapı (alternatif: Serilog) |

---

## 🔐 Güvenlik ve Şifreleme

| Konu | Açıklama |
|------|----------|
| **MD5, SHA256/512** | Verilerin hash'lenmesi, özellikle şifre saklama işlemleri için |
