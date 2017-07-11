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

    callAudio: function(audioFile)
    {
      var returnAudioString = Pointer_stringify(audioFile);
      SendMessage("InterviewerObj", "pluginAudioReturn", returnAudioString);
    },
}

mergeInto(LibraryManager.library, jsPlugin);
