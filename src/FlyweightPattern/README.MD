In this exmaple there are 5 sizes of trees (1-5) and 5000 different colors. 

A certain sized tree and its image are stored in the FlyweightFactory. 5000 FlyweightContext objects are used to represent each unique-colored tree.

By default each OriginalTree stores 10KB of image, 50MB for the 5000 trees, while FlyweightFactory stores only 5 instances of images along with 5000 FlyweightContext objects costing next to nothing compared to OriginalTree objects.

At the StressTest each OriginalTree stores 10MB of image. The program usually crashes around 15GB (150 trees) on my laptop that has 8GB RAM. YMMV.