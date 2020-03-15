using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
  public partial class Form1 : Form
  {
    // Setting the starting variables. 
    private readonly SortedList<string, bool> Questions = new SortedList<string, bool>()
    {
      { "SSDs are faster then HDDs", true },
      { "Microsoft owns GitHub", true },
      { "The ASCII code for 'A' is 100", false }
    };

    private int QuestionNumber = 0;
    private int Score = 0;
    private SortedList<string, bool> wrongAnswers = new SortedList<string, bool>();

    public Form1()
    {
      InitializeComponent();
      ShowNextQuestion();
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
      // makes sure that an answer has been selected before checking it and moving on.
      if(rdoTrue.Checked || rdoFalse.Checked)
      {
        CheckAnswer();
        ShowNextQuestion();
      }
    }

    private void ShowNextQuestion()
    {
      QuestionNumber++;

      // checks to make sure there is still more questions before showing the question and reseting the radios.
        if(QuestionNumber <= Questions.Count)
      {
        KeyValuePair<string, bool> question = Questions.ElementAt(QuestionNumber - 1);
        string questionText = question.Key;
        lblQuestion.Text = questionText;

        rdoTrue.Checked = false;
        rdoFalse.Checked = false;
      }
      else
      {
        // if there are not any questions life, ends the quiz, tells you your score, shows you what you got wrong.
        btnSubmit.Enabled = false;
        lblQuestion.Text = "QUIZ OVER!";
        MessageBox.Show($"Your score is {Score}!", "Quiz End");
        String wrongQuestions = makeDictIntoString(wrongAnswers);
        if(wrongQuestions != "")
        {
          MessageBox.Show(wrongQuestions, "Answers");
        }
        else
        {
          MessageBox.Show("You got a perfect score!", "Congrats!");
        }

      }
    }

    private void CheckAnswer()
    {
      // Checks to make sure theres still questions before checking the radios vs the correct answer, increasing the score / adding the question to the you done goofed list. 
      if (QuestionNumber <= Questions.Count)
      {
        KeyValuePair<string, bool> question = Questions.ElementAt(QuestionNumber - 1);
        bool correctAnswer = question.Value;

        if(correctAnswer && rdoTrue.Checked)
        {
          Score++;
        }
        else if (!correctAnswer && rdoFalse.Checked)
        {
          Score++;
        }
        else
        {
          wrongAnswers.Add(question.Key, question.Value);
        }
        lblScore.Text = $"Score: {Score}";
      }
    }

    private string makeDictIntoString(SortedList<string, bool> dictionary)
    {
      // Takes a dictionary and turns it into a neatly formatted string about questions and their correct answers.
      String finalString = "";
      foreach (KeyValuePair<string, bool> entry in dictionary)
      {
        finalString += ($"Question: {entry.Key}. Correct Answer: {entry.Value}.\n");
      }
      return finalString;
    }

  }
}
