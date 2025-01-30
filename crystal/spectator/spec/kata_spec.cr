require "./spec_helper"

Spectator.describe Kata do
  it "greets the given name" do
    expect(described_class.greet("World")).to eq "fail"
  end
end
