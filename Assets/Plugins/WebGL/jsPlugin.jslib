var jsPlugin =
{
    callAnimation: function(animValue)
    {
        var returnString = Pointer_stringify(animValue);
        SendMessage("InterviewerObj", "pluginAnimationReturn", returnString);
    },

    passNum: function(numValue)
    {
      var returnNum = Pointer_stringify(numValue);
      SendMessage("InterviewerObj", "pluginNumberReturn", returnNum);
    },

    speakNow: function()
    {
      console.log("speaking");
    },
}

mergeInto(LibraryManager.library, jsPlugin);
