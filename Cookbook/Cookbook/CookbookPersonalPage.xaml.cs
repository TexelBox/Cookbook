﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cookbook
{
    /// <summary>
    /// Interaction logic for CookbookPersonalPage.xaml
    /// </summary>
    public partial class CookbookPersonalPage : Page
    {
        //public List<Recipe> _recipeList;
        private BitmapImage fillStarImage = (BitmapImage)Application.Current.Resources["fillStarIcon"];
        private BitmapImage unfillStarImage = (BitmapImage)Application.Current.Resources["unfillStarIcon"];
        //Pass in a LIST of recipes. 
        public CookbookPersonalPage(List<Recipe> recipeList)
        {
            InitializeComponent();
            int num = 0;
            for (int i = 0; i < recipeList.Count; i++)
            {
                CookbookRecipes recipe = new CookbookRecipes();
                num++;
                recipe.Number = num.ToString();
                recipe.Title = recipeList[i]._name;
                recipe.Dur = recipeList[i]._duration.ToString() + "m";
                recipe.ingNum.Content = recipeList[i]._ingredients.Count.ToString() + " Ingredients";
                recipe.FoodImage = recipeList[i]._image;



                if (recipeList[i]._difficulty == Recipe.Difficulties.EASY)
                    recipe.DiffImage = (BitmapImage)Application.Current.Resources["easyIconIcon"];
                else if (recipeList[i]._difficulty == Recipe.Difficulties.MEDIUM)
                    recipe.DiffImage = (BitmapImage)Application.Current.Resources["medIconIcon"];
                else if (recipeList[i]._difficulty == Recipe.Difficulties.HARD)
                    recipe.DiffImage = (BitmapImage)Application.Current.Resources["hardIconIcon"];

                //recipe.editButton.Click += editButton_Click;
                //recipe.foodProfileButton.Click += foodProfileButton_Click;

                //Still need to add ratings
                if (recipeList[i]._rating == 1)
                {
                    recipe.Rate1Image = fillStarImage;
                    recipe.Rate2Image = unfillStarImage;
                    recipe.Rate3Image = unfillStarImage;
                    recipe.Rate4Image = unfillStarImage;
                    recipe.Rate5Image = unfillStarImage;
                }
                else if (recipeList[i]._rating == 2)
                {
                    recipe.Rate1Image = fillStarImage;
                    recipe.Rate2Image = fillStarImage;
                    recipe.Rate3Image = unfillStarImage;
                    recipe.Rate4Image = unfillStarImage;
                    recipe.Rate5Image = unfillStarImage;
                }
                else if (recipeList[i]._rating == 3)
                {
                    recipe.Rate1Image = fillStarImage;
                    recipe.Rate2Image = fillStarImage;
                    recipe.Rate3Image = fillStarImage;
                    recipe.Rate4Image = unfillStarImage;
                    recipe.Rate5Image = unfillStarImage;
                }
                else if (recipeList[i]._rating == 4)
                {
                    recipe.Rate1Image = fillStarImage;
                    recipe.Rate2Image = fillStarImage;
                    recipe.Rate3Image = fillStarImage;
                    recipe.Rate4Image = fillStarImage;
                    recipe.Rate5Image = unfillStarImage;
                }
                else if (recipeList[i]._rating == 5)
                {
                    recipe.Rate1Image = fillStarImage;
                    recipe.Rate2Image = fillStarImage;
                    recipe.Rate3Image = fillStarImage;
                    recipe.Rate4Image = fillStarImage;
                    recipe.Rate5Image = fillStarImage;
                }
                recipe.Modified = recipeList[i].modified;   //Mark this thing as modified!
                Recipes.Children.Add(recipe);
            }
            if (Recipes.Children.Count == 0)
            {
                noText.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                noText.Visibility = System.Windows.Visibility.Hidden;

            }
        }

        }
    }

