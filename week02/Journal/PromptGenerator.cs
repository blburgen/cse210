using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        //These prompts came from https://blog.gratefulness.me/self-care-journal-prompts/
        "How are you feeling in this moment? Describe all that you are experiencing within yourself.",
        "What do you need in your life right now?",
        "What is something that you're grateful for today, and why?",
        "Write down three things that you accomplished this week, no matter how small they may seem.",
        "Write about a song that always comforts you. What do you like about it?",
        "What is something that you did today that made you feel happy or proud?",
        "What is something that you're struggling with right now, and what steps can you take to address it?",
        "Where do you feel most happy and relaxed?",
        "What is one part of your life that you won't trade for anything?",
        "Choose 3 people to say thanks today. Write about why you are thankful to them.",
        "What is your idea of a happy life?",
        "List 3 things that help you feel cozy and comfortable.",
        "What is a little thing that you can do to take care of yourself?",
        "Write about one positive change in your life from the last year.",
        "Write a letter to yourself, reflecting on your strengths and the progress you've made recently.",
        "Write down three things that you want to prioritize in your self-care routine this month.",
        "What is something that you can do today to show yourself some love and kindness?",
        "Write down five things that you're looking forward to in the next week or month.",
        "What is something that you're currently worrying about, and how can you reframe your thoughts to feel more positive and empowered?",
        "What is something that you're struggling with right now, and how can you show yourself kindness and compassion in this moment?",
        "Write about a time when you felt truly happy and content. What were the circumstances, and how can you recreate that feeling in your life now?",
        "Write a letter to yourself, reflecting on your current emotions and how you're coping with them. Be kind and compassionate to yourself as you write.",
        "What is something that you're afraid of or anxious about, and what steps can you take to address those feelings?"
    };
    public PromptGenerator()
    {

    }

    public string GetRandomPromt()
    {
        Random random = new Random();
        int end = _prompts.Count;
        int number = random.Next(end);
        return _prompts[number];  
    }
}