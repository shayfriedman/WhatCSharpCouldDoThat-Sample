class Recorder
  # Initialize an array that will save the calls
  def initialize
    @calls = []
  end
   
  # Save the calls to method_missing	
  def method_missing(name, *args, &block)
    @calls << [name, args, block]
  end

  # Playback the calls on a given object	
  def playback(obj)
    @calls.each do |name, args, block|
      obj.send name, *args, &block
    end
  end
end