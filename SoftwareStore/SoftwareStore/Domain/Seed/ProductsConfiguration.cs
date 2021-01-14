using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftwareStore.Domain.Entities.App;

namespace SoftwareStore.Domain.Seed
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
            (
                new Product
                {
                    Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                    Title = "Fix-It Utilities Professional",
                    Information = "The Best Selling Disk Utility Software just got even more powerful. Fix It Utilities Professional comes packed with cutting edge. New Features designed to let you take control of your PC. Featuring the exclusive patent pending piece Analyzer Technology, 400% Faster Windows Registry Repair, a new Program Optimizer and Anti Virus Engine, as well as a dramatically redesigned and more intuitive User Interface design, Fix It Utilities is clearly the most flexible, powerful yet easy to use piece utility program available.",
                    DateAdded = new DateTime(2013, 03, 13),
                    OS = "Windows Vista, Windows 8, Windows 10, Windows 7",
                    Price = 19.90M
                },
                new Product
                {
                    Id = new Guid("88acf17c-ce69-4475-a6b0-aefe8d6a6c88"),
                    Title = "Bootable USB Stick",
                    Information = "This USB will allow you to re-install Mac on a new SSD Hard Drive, or recover your existing version if you are having system or software failure. Simple and easy to use, no guess work. Use it without technical skills. It will work with some qualifiers: your hardware must be functional and your hardware must be as close as possible to the original Apple approved for the system. The ideal install / upgrade would happen on an original machine.",
                    DateAdded = new DateTime(2020, 09, 26),
                    OS = "macOS X High Sierra 10.13",
                    Price = 28.00M
                },
                new Product
                {
                    Id = new Guid("48b8cb74-94db-4641-9895-1de2f2be8827"),
                    Title = "Laplink PCmover Express",
                    Information = "PCmover Express 11 is the ONLY software that automatically transfers files, settings, and user profiles from an old PC to a new one! It’s the easiest way to move to a new PC without leaving anything behind, even when there are different versions of Windows on the old and new PC. Nothing is changed on the old PC and nothing is overwritten on the new PC.",
                    DateAdded = new DateTime(2019, 04, 04),
                    OS = "Windows Vista, Windows 8, Windows 10, Windows XP, Windows 7",
                    Price = 19.90M
                },
                new Product
                {
                    Id = new Guid("b2f97cfb-3fc6-454a-86a5-5a04c6cc779a"),
                    Title = "Ralix Windows Emergency Boot Disk",
                    Information = "The most up to date Windows Emergency Boot Disk on the market! Below are a few of the things that this disk will do for you",
                    DateAdded = new DateTime(2019, 10, 28),
                    OS = "Windows 98, 2000, XP, Vista, 7, 10",
                    Price = 12.99M
                },
                new Product
                {
                    Id = new Guid("82dd7661-6b9b-4f24-8439-2ce7ce0c566a"),
                    Title = "AVG TuneUp",
                    Information = "AVG TuneUp is 15 years of computer optimization expertise that jogs your old PC back in shape, or keeps your new one running as fast as day 1.",
                    DateAdded = new DateTime(2019, 08, 23),
                    OS = "Windows 8, Windows 10, Mac OS X, Windows 7, Android",
                    Price = 24.99M
                },
                new Product
                {
                    Id = new Guid("ac6bcfad-63a0-444a-a9d5-a58248bfbe0b"),
                    Title = "NTI Echo 5",
                    Information = "The Best Cloning Software. It Simply Works | Make an exact copy of HDD, SSD or NVMe SSD, with Dynamic Resizing | Available in CD-ROM and Download",
                    DateAdded = new DateTime(2020, 03, 13),
                    OS = "Windows Vista, Windows 8, Windows 10, Windows 7",
                    Price = 21.99M
                },
                new Product
                {
                    Id = new Guid("0b53d140-b2f4-4474-a890-a37a74cbad2d"),
                    Title = "Avast Cleanup Premium",
                    Information = "Still pining for that brand-new PC feeling? Get it back — and keep it — with the optimization and cleaning tools offered by Avast Cleanup Premium.",
                    DateAdded = new DateTime(2019, 08, 23),
                    OS = "Windows",
                    Price = 19.99M
                },
                new Product
                {
                    Id = new Guid("a23a5ff0-561d-4a7d-a867-eb1eeacf6306"),
                    Title = "Windows Password Reset USB",
                    Information = "This software will reset your Windows login password. it is compatible with Windows 10, 8.1, 8, 7",
                    DateAdded = new DateTime(2020, 03, 11),
                    OS = "Window 10, 8, 7, Vista, XP",
                    Price = 20.99M
                },
                new Product
                {
                    Id = new Guid("4b96e514-78a7-48da-90d5-4d2c07012a8f"),
                    Title = "WinOptimizer 18",
                    Information = "Quite possibly the most comprehensive Windows optimization suite ever! Gain new disk space, disable unwanted services and boost your PC performance to the max! Protect your privacy and customize Windows to your needs.Enjoy steady performance and a lean, secure system!",
                    DateAdded = new DateTime(2020, 07, 29),
                    OS = "Windows 10, 8.1, 8, 7",
                    Price = 22.99M
                },
                new Product
                {
                    Id = new Guid("cff12241-dec0-4d7a-9af3-edcfcd0bc194"),
                    Title = "CleanMy Mac & PC",
                    Information = "CleanMy Mac & PC is one of the best and easiest to use cleaning solutions on the market for your OS. It consists of CleanMyMac for Macs & CleanMyPC for Windows based computers. CleanMyMac is the ultimate tool to keep your Mac clean and healthy.",
                    DateAdded = new DateTime(2012, 02, 14),
                    OS = "Windows Vista, Mac OS X, Windows XP, Windows 7",
                    Price = 15.99M
                }
            );
        }
    }
}
