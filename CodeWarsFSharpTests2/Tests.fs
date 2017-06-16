namespace CodeWarsFSharpTests2

open System
open Xunit
open CodeWarsFSharp

module Tests =
 [<Fact>]
 let ``AreTheySameTest``() = 
     let a1 = [121; 144; 19; 161; 19; 144; 19; 11]
     let a2 = [11*11; 121*121; 144*144; 19*19; 161*161; 19*19; 144*144; 19*19]
     Assert.True(AreTheySame.comp(a1,a2))
     let a3 = [121; 144; 19; 161; 19; 144; 19; 11]
     let a4 = [11*21; 121*121; 144*144; 19*19; 161*161; 19*19; 144*144; 19*19]
     Assert.False(AreTheySame.comp(a3,a4))
