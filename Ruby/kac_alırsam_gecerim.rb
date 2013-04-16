#! usr/bin/ruby
# encoding: utf-8

def hesapla()
  print "Öncelikle geçme notunuz kaç? :"
  g = gets.chomp
  print "Vize notunuzu söylermisiniz :"
  v = gets.chomp
  puts "En düşük notla geçebilmeniz için #{(60 - (0.4 * v.to_f)) / 0.6} almanız gerek.. "
end

if __FILE__ == $0
  hesapla()
end
