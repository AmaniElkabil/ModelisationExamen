using System;

public class Question
{
	public  Question()
	{
		int nbr_quetion
	}
	public void réponse() 
	{}
}
public class Ouverte : Question
{
	string reponse;
	string correction;
    public void reponseouve() 
	{
		char text;
	}
}

public class QCM : Question
{
    string reponse;
	string correction;
	public void QCM() 
	{ 
	}
}

public class Choix_multiple : QCM
{
	string question;
}

public class Seul_reponse : Choix_multiple
{
}
public class Plsr_reponse : Choix_multiple
{
}

public class Dichotomique : QCM
{
    public class reponse_dia
	{
		bool reponse;
		reponse_dia();
	}

}


public class note
{
	float note;
    string certitude;
	bool question
	public float peu_sur(string certitude = "peu_sur" )
	{
		if (question == true)
		{
			note = 1;
		}
		else
			note = 0;
	}
    public float moyenne_sur(string certitude = "moyenne_sur")
    {
        if (question == true)
        {
			note = 2;

        }
        else
            note = -1;
    }
    public float tout_sur(string certitude = "tout_sur")
    {
        if (question == true)
        {
            note = 3;

        }
        else
            note = -3;
    }
}