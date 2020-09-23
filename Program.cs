/* Lands of the Lost - a game */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Math;
using System.Linq;
using System.Text;
using System.Random;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandsOfTheLost
{

    class Item
    {
        public string objName;
        public double weight;                                          //in lbs
        public double absValue;                                        //in G
        public int numInstances;                                    //the number of instances in the world, used for inflating or deflating the value of an item.
        public double inflateValue(double diffValue)
        {
            diffValue = absValue+(absValue*infRate);
        }
        public double deflateValue(int diffValue)
        {

        }
    }
    class Weapons : Item
    {

    }
    class GameClass
    {
        public string ClassName;
        public enum ClassType 
        {
            COMBAT,
            MAGIC,
            TECH,
            SOCIAL,
            THIEF
        }
    }
    class Character
    {
        //Character Essentials
        public string CharName;
        public string CharRace;
        public GameClass CharClass;
        public bool CharSex;                                        //0 = Female, 1 = Male
       
        //Attributes
        public int StatSTR;
        public int StatAGI;
        public int StatCON;
        public int StatINT;
        public int StatWIS;
        public int StatCHA;

        //Skills
        //Combat
        public int SkillOneHanded;
        public int SkillTwoHanded;
        public int SkillPolearm;
        public int SkillArchery;
        public int SkillCrossbow;
        public int SkillThrowing;
        public int SkillFirearms;

        //Magic
        public int SkillAlchemy;                                  //Manipulation of chemical compounds to change their properties
        public int SkillConjuration;                              //Manipulation of spirits, to bring them into this world or cast them out.
        public int SkillElemental;                                //Manipulation of the Six Elements: Earth, Fire, Water, Air, Electromagnetism, and Force
        public int SkillNatural;                                  //Manipulation of plants, animals and the animistic spirits, 
        public int SkillThaumaturgy;                              //Manipulation of miracles to create, restore, and strengthen life
        public int SkillNecromancy;                               //Manipulation of life and death to reanimate, 

        //Technological
        public int SkillSmithing;
        public int SkillElectronics;
        public int SkillMedicine;
        public int SkillMechanics;
        public int SkillExplosives;

        //Social
        public int SkillLeadership;
        public int SkillPersuasion;
        public int SkillTrade;
        public int 

        //Thief
        public int SkillSneak;
        public int SkillPickpocket;
        public int SkillTrap;

        //Character Details
        public int CurrentHP, MaxHP;
        public int CurrentMP, MaxHP;
        public int Level { get; set; }                             //
        public double Gold { get; set; }                              //known in-game as Gelden Thaler
        public int ExperiencePoints { get; set; }
        public int[] Inventory;                                  //an array of items on the person



        public void generateBandit()
        {
            
        }
        public void generateCitizen()                           //generates a random civilian
        {

        }
    }
    class Enemy : Character
    {

    }
    class Player : Character
    {
        public string playerName;
        public void playerCreation()
        {
            _newPlayer = new Player;
            Console.WriteLine("Create your character.");
            Console.WriteLine("First, input your character's name: ");
            string Player.playerName = Console.ReadLine();
 
        }
    }
    class Map
    {

    }
    class Location
    {

    }
    class SaveFile 
    {
        public string fileName;
        public void save()
        {
            if (!File.Exists("LostLand.SAV"))
            {
                File.Create("LostLand.SAV");
                for 
            }
        }
        public void load()
        {
            if (!File.Exists("LostLand.SAV"))
            {
                Console.WriteLine("No save file found!");
                break;
            }
            File.Open("LostLand.SAV", FileMode.Open);
            
        }
    }
    class Game
    {
        static void Main(string[] args)
        {
        }
    }
}
