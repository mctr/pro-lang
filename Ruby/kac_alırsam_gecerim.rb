#! usr/bin/ruby
# encoding: utf-8

def hesapla()
  print "Öncelikle geçme notunuz kaç? :"
  g = gets.chomp
  print "Vize notunuzu söylermisiniz :"
  v = gets.chomp
  result = (g.to_i - (0.4 * v.to_f)) / 0.6
  if result < 50
    puts "Normalde #{result} almanız yetiyor ama En az 50 almanız gerek.."
  else
    puts "En düşük notla geçebilmeniz için #{result} almanız gerek.."
  end
end

if __FILE__ == $0
  hesapla()
end
