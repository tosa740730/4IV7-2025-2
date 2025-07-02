namespace PA_GUIA_INGLES
{
    public partial class FrmTemas : Form
    {
        public FrmTemas()
        {
            InitializeComponent();
            CmbTemas.Items.Add("REPORTED SPEECH");
            CmbTemas.Items.Add("GET USED TO, BE USED TO + ING");
            CmbTemas.Items.Add("SECOND AND THRID CONDITIONAL");
            CmbTemas.Items.Add("WISH + SIMPLE PAST, WISH + WOULD, WISH + PAST PERFECT");
            CmbTemas.Items.Add("PASSIVE VOICE");
            CmbTemas.Items.Add("RELATIVE CLAUSES");
        }

        private void CmbTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbTemas.SelectedIndex)
            {
                case 0:
                    LblResultados.Text = @"REPORTED SPEECH

HOW REPORTED SPEECH WORKS
Reported speech is used to express what someone has said without quoting their exact words. Instead of using the 
exact words of a person, we paraphrase what they said. It's widely used in everyday conversation, media, and writing.

BASIC STRUCTURE OF REPORTED SPEECH
The basic structure of reported speech is:
Subject + reporting verb + (that) + subject + verb in the correct tense.

COMMON REPORTING VERBS INCLUDE:
•	Say
•	Tell
•	Ask
•	Explain
•	Advise
•	Claim

For example:
•	He said that he was tired.
•	She told me that she had finished her homework.

TENSE CHANGES IN REPORTED SPEECH
When we shift from direct speech to reported speech, in most cases, there is a change in the verb tense.

GENERAL RULES FOR TENSE CHANGES:

PRESENT SIMPLE → PAST SIMPLE
o	Direct speech: ""I eat breakfast every morning.""
o	Reported speech: She said (that) she ate breakfast every morning.

PRESENT CONTINUOUS → PAST CONTINUOUS
o	Direct speech: ""I am studying English.""
o	Reported speech: He said (that) he was studying English.

PRESENT PERFECT → PAST PERFECT
o	Direct speech: ""I have finished my work.""
o	Reported speech: She said (that) she had finished her work.

PAST SIMPLE → PAST PERFECT
o	Direct speech: ""I saw the movie.""
o	Reported speech: He said (that) he had seen the movie.

WILL → WOULD
o	Direct speech: ""I will visit the museum tomorrow.""
o	Reported speech: She said (that) she would visit the museum the next day.

EXCEPTIONS:
There are some cases where the verb tense doesn't change:
1. If the information is generally true or a universal truth. For example:
1.1. Direct speech: ""The sun rises in the east.""
1.2. Reported speech: He said that the sun rises in the east. (No tense change because it's a general truth.)

2. If the sentence is being quoted in a context that doesn't change, such as when referring to past events 
    that are still relevant. For example:
2.1. Direct speech: ""I am your father.""
2.2. Reported speech: He said (that) he is my father. (Tense stays because the situation is still valid.)

PRONOUNS AND TIME EXPRESSIONS
When using reported speech, it's important to adjust the pronouns and time expressions.
Example of pronouns:
•	Direct speech: ""I will see her tomorrow.""
•	Reported speech: He said that he would see her the next day.

Example of time expressions:
•	Now → then
•	Today → that day
•	Tomorrow → the next day / the following day
•	Yesterday → the day before / the previous day

REPORTED QUESTIONS

STRUCTURE
We follow this pattern:
•	For yes/no questions: asked + if/whether + subject + verb
•	For wh- questions: asked + wh-word + subject + verb

Examples
Direct Speech (Yes/No Question):
•	""Did she finish the report?"" Reported Speech:
•	He asked if she had finished the report.

Direct Speech (Wh- Question):
•	""Where do you live?"" Reported Speech:
•	She asked where I lived.

EXAMPLES:

Example 1: Present Simple to Past Simple
•	Direct Speech: ""I go to the gym every morning.""
•	Reported Speech: He said (that) he went to the gym every morning.

Example 2: Future with ""will"" to conditional with ""would""
•	Direct Speech: ""I will help you with your project.""
•	Reported Speech: She said (that) she would help me with my project.

Example 3: Questions in reported speech
When a person asks something, the structure of the question changes.
•	Direct Speech: ""What time does the train leave?""
•	Reported Speech: He asked what time the train left.

Note: Questions in reported speech don’t need a question mark, and the verb is placed in normal 
declarative order, not question order.

Example 4: Using ""tell"" and “say”
When we use tell instead of say, we don’t need the ""that"", and we add an object (the person to whom something is told).
•	Direct Speech: ""I will call you later.""
•	Reported Speech: She told me (that) she would call me later.";

                    break;

                case 1:
                    LblResultados.Text = @"GET USED TO, BE USED TO + ING

1. ""GET USED TO""

""Get used to"" refers to the process of becoming accustomed to something that is new or unfamiliar. It focuses on the 
change or transition over time, meaning you haven't fully adjusted yet, but you're in the process of doing so.

STRUCTURE:
Subject + get + used to + (noun/verb-ing)

Examples:
•	It took me a while to get used to waking up early. (I wasn’t used to waking up early at first, but now I am.)
•	I am still getting used to the cold weather here. (The weather is new to me, and I am in the process of adjusting.)
•	She is getting used to driving on the left side of the road. (She wasn't used to it at first, but she is adjusting now.)

2. ""BE USED TO""

""Be used to"" means that something is already familiar to you, and you are accustomed to it. It suggests that 
you’ve already gone through the process of getting used to something, and now it’s a normal part of your routine or experience.

STRUCTURE:
Subject + be (am/are/is/was/were) + used to + (noun/verb-ing)

Examples:
•	I am used to waking up early now. (I’ve adjusted to waking up early, and it’s normal for me now.)
•	She is used to living in a big city. (She’s already familiar with life in a big city.)
•	They were used to the hot climate. (They had already adjusted to the heat.)

KEY DIFFERENCES BETWEEN ""Get used to"" and ""Be used to""
•	""Get used to"" is about the process of becoming familiar with something, while ""be used to"" is about being 
    already familiar with something or someone.
•	""Get used to"" is often used when something is new or unfamiliar, whereas ""be used to"" is used when something 
    has already become normal or comfortable for you.";

                    break;

                case 2:
                    LblResultados.Text = @"SECOND AND THRID CONDITIONAL

1.	SECOND CONDITIONAL

USE:
The Second Conditional is used to talk about unreal, imaginary, or hypothetical situations in the present or 
future. These are things that are unlikely or impossible to happen.

STRUCTURE:
If + past simple, would + base verb
Clause 1 (If...)	Clause 2 (would...)
If I won the lottery,	I would travel the world.

Examples:
•	If I had more free time, I would learn another language.
•	If she were taller, she would play basketball.
•	If we lived in Paris, we would visit the Eiffel Tower every weekend.

 Note: With ""I/he/she/it"", we often use ""were"" instead of ""was"" in formal English:
•	Correct: If I were you, I would study more.
•	(In informal English, ""was"" is sometimes used.)

 Meaning:
These situations are not true now, but we're imagining what would happen if they were true.

2.	THRID CONDITIONAL

USE:
The Third Conditional is used to talk about past situations that didn’t happen, and their imagined results. It's 
all about regret, hypotheticals, and ""what if"" moments in the past.

STRUCTURE:
If + past perfect, would have + past participle
Clause 1 (If...)	Clause 2 (would have...)
If I had studied more,	I would have passed the exam.

Examples:
•	If she had left earlier, she would have caught the train.
•	If we had taken a taxi, we would have arrived on time.
•	If they hadn't forgotten the tickets, they would have seen the concert.

This conditional is 100% imaginary — the past cannot be changed.";

                    break;

                case 3:
                    LblResultados.Text = @"WISH + SIMPLE PAST, WISH + WOULD, WISH + PAST PERFECT

1. WISH + SIMPLE PAST

USE:
Wish + simple past is used  to express wishes about situations that are not real in the present or future. That 
is, they are situations that are not happening or that are not possible at this time.

STRUCTURE:
Wish + subject + past simple verb

Examples:
o	I wish I had a car. (I don't have a car now, but I would like to.)
o	She wishes she were taller. (She is not tall, but she would like to be.)

Note: Although in most cases we use ""was"" for the first person singular (I, he, she), in formal or more 
correct English, ""were"" is used with all people. Example: ""If I were you, I would study more.""

More examples:
•	I wish I knew the answer. (I don't know the answer now.)
•	They wish they could travel more often. (They are not able to travel now.)

2. WISH + WOULD
Use:
Wish + would is used  to express wishes about the future or to express dissatisfaction or frustration about something 
that is not changing. Often, it refers to something we want to change  or improve.

STRUCTURE:
Wish + subject + would + verb

Examples:
o	I wish he would stop talking so loudly. (I am frustrated because he doesn't stop talking loudly.)
o	She wishes they would help her more often. (She wants them to help her, but they don't.)

More examples:
•	I wish you would hurry up. (You are taking too long.)
•	He wishes she would be more punctual. (He is frustrated because she is always late.)

3. WISH + PAST PERFECT

USE:
Wish + past perfect is used  to express regrets or wishes about the past, that is, something that did not happen and 
that we wish had happened differently.

STRUCTURE:
Wish + subject + had + past participle

Examples:
o	I wish I had studied harder for the exam. (I didn’t study hard enough, and now I regret it.)
o	She wishes she hadn't gone to the party. (She regrets going to the party.)

More examples:
•	They wish they had saved more money last year. (They didn’t save enough, and they regret it now.)
•	I wish we hadn't missed the concert. (We missed it, and we regret it.)";

                    break;

                case 4:
                    LblResultados.Text = @"PASSIVE VOICE

1. MODAL VERBS PASSIVE

Let's explore Modal Verbs in the Passive Voice! Modal verbs are auxiliary verbs that express necessity, possibility, 
ability, permission, or obligation, such as can, could, may, might, must, should, would, will.

When we combine modal verbs with the passive voice, the focus of the sentence shifts from the doer of the action to 
the recipient of the action. The construction for passive modal verbs is:

Modal Verb + be + past participle (main verb)

Let’s break down the rules and look at some examples.

HOW TO FORM MODAL VERBS IN THE PASSIVE:

a)	STRUCTURE:
o	Affirmative: Modal verb + be + past participle

Example: The report must be finished by tomorrow.

o	Negative: Modal verb + not + be + past participle

Example: The documents shouldn’t be signed yet.

o	Question: Modal verb + subject + be + past participle?

Example: Can the test be taken online?

Examples of Modal Verbs in the Passive:

•	Can:
o	Active: People can read this book in the library.
o	Passive: This book can be read in the library.
(The focus is on the book being read, not who reads it.)

•	Must:
o	Active: They must complete the task by Friday.
o	Passive: The task must be completed by Friday.
(The focus is now on the task, not on who must complete it.)

•	Should:
o	Active: You should send the email before noon.
o	Passive: The email should be sent before noon.
(The focus is on the email being sent, not who should send it.)

•	May:
o	Active: They may finish the project by next week.
o	Passive: The project may be finished by next week.
(The focus is on the project being finished, not who finishes it.)

•	Could:
o	Active: They could complete the work faster.
o	Passive: The work could be completed faster.
(The focus is now on the work being completed.)

•	Will:
o	Active: They will review the documents tomorrow.
o	Passive: The documents will be reviewed tomorrow.
(The focus is on the documents being reviewed.)


2. FUTURE PASSIVE

STRUCTURE OF THE FUTURE PASSIVE:

The Future Passive is formed with the following structure:

Subject + will + be + past participle

This structure can be used in affirmative, negative, and question forms.

Affirmative:
•	Subject + will + be + past participle
Example:
•	The report will be submitted by the end of the day.
(The report is the focus, and it will be submitted in the future.)

Negative:
•	Subject + will + not + be + past participle
Example:
•	The documents will not be processed until next week.
(The documents will not be processed in the future.)

Question:
•	Will + subject + be + past participle?
Example:
•	Will the project be finished by tomorrow?
(The focus is on whether the project will be finished, not on who finishes it.)

Examples of Future Passive:
•	The meeting will be held next Monday.
(The meeting is the focus, and someone will hold it in the future.)

•	The packages will be delivered tomorrow.
(The packages will receive the action of being delivered.)

•	The contract will not be signed before the end of the month.
(The contract is the focus, and it will not be signed in the future.)

•	The final decision will be made by the committee.
(The decision will be made, but the doer (the committee) is not the focus.)

When Do We Use the Future Passive?
We use the Future Passive when:
1.	The focus is on the action or the recipient of the action rather than who will perform the action.
2.	We want to express actions that are scheduled, planned, or expected to happen in the future.
3.	We don't know or don't want to specify who will do the action.


3. PRESENT PASSIVE

The present passive is used to describe actions happening now or regularly, focusing on the action rather 
than who is doing it.

STRUCTURE:

Subject + am/is/are + past participle

Examples:
•	The homework is checked by the teacher every day.
•	New products are delivered to the store every morning.


4. PAST PASSIVE

The past passive describes actions that happened in the past, again focusing on the action rather than the doer.

STRUCTURE: 

Subject + was/were + past participle

Examples:
•	The invitations were sent yesterday.
•	The building was designed by a famous architect last year.


5. QUESTIONS IN PASSIVE VOICE

STRUCTURE:

To form questions in the passive voice, we follow this pattern:
•	Present Passive: Am/Is/Are + subject + past participle + (by whom)?
•	Past Passive: Was/Were + subject + past participle + (by whom)?

Examples:
Present Passive:
•	Is the work finished by the team?
•	Are the reports sent every day?

Past Passive:
•	Was the message delivered on time?
•	Were the paintings exhibited in the gallery last week?";

                    break;

                case 5:
                    LblResultados.Text = @"RELATIVE CLAUSES

1.	DEFINING RRELATIVE CLAUSES

A defining relative clause gives essential information about the noun it refers to. Without it, the sentence 
would be incomplete or unclear.

Note: We can use that instited of which/who and use when mention 2 or more things.

Example:
•	The scientist who discovered the new element won a prestigious award. (The information is necessary to identify 
    which scientist is being referred to.)

2.	NON-DEFINING RRELATIVE CLAUSES

A non-defining relative clause adds extra, non-essential information. If removed, the sentence remains 
meaningful. These clauses are separated by commas.

Note:No use “that” and use when mention only one thing.

Example:
•	Marie Curie, who was the first woman to win a Nobel Prize, made significant discoveries in 
    radioactivity. (The information about Marie Curie is additional and not crucial to understand the sentence.)";

                    break;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmInicio frmAnterior;
            frmAnterior = new FrmInicio();

            this.Close();
        }
    }
}
