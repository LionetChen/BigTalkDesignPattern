In this exmaple there are 5 sizes of trees (1-5) and 500 different colors. 

A certain sized tree and its image are stored in the FlyweightFactory. 5000 FlyweightContext objects are used to represent each unique-colored tree.

By default each OriginalTree stores 10KB of image, 5MB for the 500 trees, while FlyweightFactory stores only 5 instances of images along with 500 FlyweightContext objects costing next to nothing compared to OriginalTree objects.

At the StressTest each OriginalTree stores 10MB of image. The program usually crashes around 15GB (150 trees) on my laptop that has 8GB RAM. YMMV.

After trying out GitHub workflow, it seems they can host 5000 trees in the stress test which costs ~500GB RAM without crashing. So we manually throw OutOfMemoryException at 1GB of RAM usage to simualte a memory drain.

2022-09-28 Reduce time and RAM usage by testing 500 trees instead of 5000. Added a StressTest for FlyweightTree which will not incur the OOM exception.

**Note:** sometimes RAM usage will be negative due to GC of last tests' RAM