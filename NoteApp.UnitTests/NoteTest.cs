﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        [Test(Description = "Позитивный тест геттера Name")]
        public void NoteNameGet_CorrectValue()
        {
            var expected = "Заголовок";
            var note = new Note("", "", NoteCategory.Documents, DateTime.Now, DateTime.Now);
            note.Name = expected;
            var actual = note.Name;
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильный заголовок");
        }

        [Test(Description = "Позитивный тест сеттера Name")]
        public void NoteNameSet_CorrectValue()
        {
            var expected = "Заголовок_книжки";
            var note = new Note("Заголовок_книжки", "", NoteCategory.Documents, DateTime.Now, DateTime.Now);
            note.Name = expected;
            Assert.AreEqual(expected, note.Name, "Сеттер Name устанавливает неправильное значение");
        }
        [Test(Description = "Негативный тест сеттера Name, присваивение более 50 значений")]
        public void NoteNameSet_InCorrectValue()
        {
            var wrongName = "000000000000000000000000000000000000000000000000000";
            var note = new Note("0000000000000000000000000000000000000000000000000", "", NoteCategory.Documents, DateTime.Now, DateTime.Now);
            Assert.Throws<ArgumentException>(() => { note.Name = wrongName; }, "Присваивение более 50 значений!");
        }
        [Test(Description = "Позитивный тест сеттера Text")]
        public void TitleTextSet_CorrectValue()
        {
            var expected = "Текст";
            var note = new Note("", "Текст", NoteCategory.Documents, DateTime.Now, DateTime.Now);
            note.Text = expected;
            Assert.AreEqual(expected, note.Text, "Сеттер Text устанавливает неправильное значение");
        }
        [Test(Description = "Позитивный тест сеттера Category")]
        public void NoteCategorySet_CorrectValue()
        {
            var expected = NoteCategory.Misc;
            var note = new Note("", "", NoteCategory.Misc, DateTime.Now, DateTime.Now);
            var actual = note.noteCategory;
            Assert.AreEqual(expected, actual, "Сеттер NoteCategory устанавливает неправильное значение");
        }
    }
}
