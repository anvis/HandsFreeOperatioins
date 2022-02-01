using Repository;
using System;

namespace RepositoryFactory
{
  public static class Repo
  {
    public static IPrepRepository GetPrepRepository()
    {
      return new PrepRepository();
    }
  }
}
